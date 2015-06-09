using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VMpart1
{
    class controleur
    {
        private static modele vmodele;

        public static modele gsVmodele
        {
            get { return controleur.vmodele; }
            set { controleur.vmodele = value; }
        }
        private static bool vconnecte;

        public static bool gsVconnecte
        {
            get { return controleur.vconnecte; }
            set { controleur.vconnecte = value; }
        }
        private static Medecin fmedecin;
        private static Motdepasse fmotdepasse;
        private static Visite fvisite;


        public static void init()
        {
            vmodele = new modele();
            vconnecte = false;
        }

        public static void recuperer(Form1 v)
        {
            string id,mdp;
            if (vmodele.gsConnopen == false)
            {
                fmotdepasse = new Motdepasse();
                if (fmotdepasse.Visible == false)
                {
                    

                    if (fmotdepasse.ShowDialog() == DialogResult.OK)
                    {
                        mdp = fmotdepasse.gsTbmdp.Text;
                        id = fmotdepasse.gsTbidentifiant.Text;
                        vmodele.seconnecter();
                        vmodele.seconnecter();
                        bool connected = vmodele.connectuser(id, mdp);
                        if (connected)
                            {
                                vmodele.chargerVM(id);
                                fmedecin = new Medecin(vmodele.gsDvmedecin);
                                fmedecin.MdiParent = v;
                                fmedecin.Show();
                            }
                                else
                                {
                                    MessageBox.Show("ERREUR, votre identifiant ou votre mot de passe n'est pas correct !", "PBS connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                    }
                }
            }
        }

        public static void filtre(string num)
        {
            fvisite.filtre(vmodele.gsDvvisite, num);
        }
    }
}

         

