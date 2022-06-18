using PG_Arts.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PG_Arts
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public static int num;
        CommandeCrud commandeCrud = new CommandeCrud();
        AffecterCrud affecterCrud = new AffecterCrud();
        ServeurCrud serveurCrud = new ServeurCrud();
        ContientCrud contientCrud = new ContientCrud();
        private void Form3_Load(object sender, EventArgs e)
        {




            DataTable tableRaport = new DataTable();
          
            tableRaport.Columns.Add("num_cmd", Type.GetType("System.String"));
            tableRaport.Columns.Add("num_tab", Type.GetType("System.String"));
            tableRaport.Columns.Add("date_com", Type.GetType("System.String"));
            tableRaport.Columns.Add("nb_personnes", Type.GetType("System.String"));
            tableRaport.Columns.Add("heure_paiement", Type.GetType("System.String"));
            tableRaport.Columns.Add("mode_paiement", Type.GetType("System.String"));
            
            tableRaport.Columns.Add("nomServeur", Type.GetType("System.String"));
            tableRaport.Columns.Add("prenomServeur", Type.GetType("System.String"));
            tableRaport.Columns.Add("libelle", Type.GetType("System.String"));
            tableRaport.Columns.Add("type_plat", Type.GetType("System.String"));
            tableRaport.Columns.Add("prix", Type.GetType("System.Double"));
            tableRaport.Columns.Add("quantite", Type.GetType("System.Double"));
           
            DataRow RowRapportBS;
            Commande cmd = commandeCrud.Commande(num);

            String nomSrv = affecterCrud.getNomSRV(cmd.num_tab);
            String prenomSrv = affecterCrud.getPrenomSRV(cmd.num_tab);
           
                
                //MessageBox.Show(nomSrv + "......." + prenomSrv);
                RowRapportBS = tableRaport.NewRow();

                RowRapportBS["num_cmd"] = cmd.num_cmd;
                RowRapportBS["num_tab"] = cmd.num_tab;
                RowRapportBS["date_com"] = cmd.date_com.Date.ToShortDateString();
                RowRapportBS["nb_personnes"] = cmd.nb_personnes;
                RowRapportBS["heure_paiement"] = cmd.heure_paiement;
                RowRapportBS["mode_paiement"] = cmd.mode_paiement;
                RowRapportBS["nomServeur"] = nomSrv;
                RowRapportBS["prenomServeur"] = prenomSrv;

                tableRaport.Rows.Add(RowRapportBS);

                List<Contient> listdata = contientCrud.Contenu(num);

                foreach (var res in listdata)
                {
                    if (res.num_cmd == num)
                    {
                        RowRapportBS = tableRaport.NewRow();

                        Plat plat = contientCrud.getPlat(res.code_plat);
                        RowRapportBS["libelle"] = plat.libelle;
                        RowRapportBS["type_plat"] = plat.type_plat;
                        RowRapportBS["prix"] = plat.prix;
                        RowRapportBS["quantite"] = res.quantite;


                        tableRaport.Rows.Add(RowRapportBS);
                    }


                }

                CrystalReport1 crt = new CrystalReport1();
                crt.SetDataSource(tableRaport);
                crystalReportViewer1.ReportSource = crt;

                crystalReportViewer1.Refresh();
            
            
            //facture.SetDataSource(db.Commandes.ToList());
            //crystalReportViewer1.ReportSource = facture;
            //crystalReportViewer1.SelectionFormula = "{PG_Arts_Data_Commande.num_tab}=7";
            //crystalReportViewer1.Refresh();
        }
    }
}
