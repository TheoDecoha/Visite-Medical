using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;


namespace VMpart1
{
    public class modele
    {
        private MySqlDataAdapter mySqlDataAdapterVM = new MySqlDataAdapter();
        private DataSet dataSetVM = new DataSet();
        private DataView dvmedecin = new DataView();

        public DataView gsDvmedecin
        {
            get { return dvmedecin; }
            set { dvmedecin = value; }
        }
        private DataView dvvisite = new DataView();

        public DataView gsDvvisite
        {
            get { return dvvisite; }
            set { dvvisite = value; }
        }

        public modele() { }

        private MySqlConnection myConnection;
        private bool connopen = false;

        public bool gsConnopen
        {
            get { return connopen; }
            set { connopen = value; }
        }
        private bool errgrave = false;

        public bool gsErrgrave
        {
            get { return errgrave; }
            set { errgrave = value; }
        }

        public void seconnecter()
        {
            string myConnectionString = "Database=visite_medicale;Server=localhost;User Id=visite_medicale;Password=theo49";
            myConnection = new MySqlConnection(myConnectionString);
            connopen = true;
            try // tentative 
            {
                myConnection.Open();
            }
            catch (Exception err)// gestion des erreurs
            {
                MessageBox.Show("Erreur ouverture bdd : " + err, "PBS connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connopen = false;
                errgrave = true;
            }
        }

        public bool connectuser(string id, string mdp)
        {
            seconnecter();
            MySqlCommand vcommand = myConnection.CreateCommand();
            vcommand.CommandText = "SELECT COUNT(*)FROM VM WHERE identifiant = '" + id + "' and mp = MD5( '"+ mdp + "')";
            Int64 nb = (Int64)vcommand.ExecuteScalar();
            sedeconnecter();
            return(nb > 0 );
        }

        public void sedeconnecter()
        {
            if (!connopen)
                return;
            try
            {
                myConnection.Close();
                myConnection.Dispose();
                connopen = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur fermeture bdd : " + err, "PBS deconnection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }

        public void chargerVM(String id)
        {
            
            seconnecter();
            if (!connopen)
                return;
            mySqlDataAdapterVM.SelectCommand = new MySqlCommand("SELECT * FROM medecin WHERE CAST(SUBSTR(cp, 1, 2) AS UNSIGNED) IN (SELECT num_departement FROM departement WHERE num_vm IN (SELECT num_vm FROM vm WHERE identifiant='kevin')); SELECT * FROM visite;", myConnection);
            try
            {
                dataSetVM.Clear();
                mySqlDataAdapterVM.Fill(dataSetVM);
                MySqlCommand vcommand = myConnection.CreateCommand();
                vcommand.CommandText = "SELECT AUTO_INCREMENT as last_id FROM INFORMATION_SCHEMA.TABLES WHERE table_name = 'medecin'"; // attention si plusieurs table medecin dans les bdd diverses plante donc personnalisez le nom de la table medecin 
                UInt64 dernummedecin = (UInt64)vcommand.ExecuteScalar();
                vcommand.CommandText = "SELECT AUTO_INCREMENT as last_id FROM INFORMATION_SCHEMA.TABLES WHERE table_name = 'visite'"; // attention si plusieurs table visite idem 
                UInt64 dernumvisite = (UInt64)vcommand.ExecuteScalar();
                dataSetVM.Tables[0].Columns[0].AutoIncrement = true;
                dataSetVM.Tables[0].Columns[0].AutoIncrementSeed = (long)dernummedecin;
                dataSetVM.Tables[0].Columns[0].AutoIncrementStep = 1;
                dataSetVM.Tables[1].Columns[0].AutoIncrement = true;
                dataSetVM.Tables[1].Columns[0].AutoIncrementSeed = (long)dernumvisite;
                dataSetVM.Tables[1].Columns[0].AutoIncrementStep = 1;
                dvmedecin = dataSetVM.Tables[0].DefaultView;
                dvvisite = dataSetVM.Tables[1].DefaultView;
                dvmedecin.Sort = "nom_m asc";
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement datasetVM : " + err, "PBS table medecin ou visite", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
            sedeconnecter();
        }
    }
        

}
