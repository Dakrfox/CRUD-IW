using CRUD_IW.Data;
using CRUD_IW.Model;
using System.Data;

namespace CRUD_IW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView();
        }
        bool queried = false;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_address.Text.Trim() == "" 
                | txt_age.Text.Trim() == ""
                | txt_cc.Text.Trim() == ""
                | txt_Lnames.Text.Trim() == ""
                | txt_names.Text.Trim() == "")
            {
                MessageBox.Show("registro invalido, por favor revise todos los campos estan diligenciados correctamente");
            }
            else
            {
                try
                {
                    Client cli = new Client();
                    cli.Names = txt_names.Text.Trim();
                    cli.Lastnames = txt_Lnames.Text.Trim();
                    cli.Document = txt_cc.Text.Trim();
                    cli.Age = Int32.Parse(txt_age.Text.Trim());
                    cli.Address = txt_address.Text.Trim(); 
                    if (check_masculino.Checked==true)
                    {
                        cli.Sex = "MASCULINO";
                    }
                    if (check_femenino.Checked)
                    {
                        cli.Sex = "FEMENINO";
                    }
                    if (check_intersexual.Checked)
                    {
                        cli.Sex = "INTERSEXUAL";
                    }
                    else
                    {
                        MessageBox.Show("something went wrong!");
                    }

                    if (Clients.saveCLient(cli))
                    {
                        MessageBox.Show("Agregado Exitoso");
                        clean();
                    }
                    else
                    {
                        MessageBox.Show("lo sentimos hubo un error, intentelo nuevamente");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            listView();
            
        }

        private void clean()
        {
            txt_names.Text = "";
            txt_Lnames.Text = "";
            txt_cc.Text = "";
            txt_age.Text = "";
            txt_address.Text = "";
            check_femenino.Checked = false;
            check_masculino.Checked = false;
            check_intersexual.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (txt_cc.Text.Trim() =="")
            {
                MessageBox.Show("El campo de ID no puede estar vacio");
            }
            else
            {
               Client cli = Clients.cli_query(txt_cc.Text.Trim());
                if (cli == null)
                {
                    MessageBox.Show("no existe el cliente con documento #ID: " + txt_cc.Text.Trim());
                    queried = true;
                }
                else
                {
                    txt_names.Text = cli.Names;
                    txt_Lnames.Text = cli.Lastnames;
                    txt_cc.Text = cli.Document;
                    txt_age.Text = cli.Age.ToString();
                    txt_address.Text = cli.Address;
                    if (cli.Sex =="MASCULINO")
                    {
                        check_masculino.Checked = true;
                    }
                    else if (cli.Sex == "FEMENINO")
                    {
                        check_femenino.Checked = true;
                    }
                    else if (cli.Sex == "INTERSEXUAL")
                    {
                        check_intersexual.Checked = true;
                    }
                    else
                    {
                        MessageBox.Show("something went wrong!");
                    }
                    queried = true;
                    
                    
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (!queried)
            {
                MessageBox.Show("primero debe consultar el cliente");
            }
            else
            {
                try
                {
                    Client cli = new Client();
                    cli.Names = txt_names.Text.Trim();
                    cli.Lastnames = txt_Lnames.Text.Trim();
                    cli.Document = txt_cc.Text.Trim();
                    cli.Age = Int32.Parse(txt_age.Text.Trim());
                    cli.Address = txt_address.Text.Trim();
                    if (check_masculino.Checked == true)
                    {
                        cli.Sex = "MASCULINO";
                    }
                    else if (check_femenino.Checked)
                    {
                        cli.Sex = "FEMENINO";
                    }
                    else if (check_intersexual.Checked)
                    {
                        cli.Sex = "INTERSEXUAL";
                    }
                    else
                    {
                        MessageBox.Show("something went wrong!");
                    }

                    if (Clients.updateCLient(cli))
                    {
                        queried = false;
                        MessageBox.Show("actualizacion Exitosa");
                        clean();

                    }
                    else
                    {
                        MessageBox.Show("lo sentimos hubo un error, intentelo nuevamente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            listView();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable data = Clients.queryClientOver25();
            if (data == null)
            {
                MessageBox.Show("error en la muestra tabla nula");
            }
            else
            {
                view_tb.DataSource = data.DefaultView;
            }
        }
        private void listView()
        {
            DataTable data = Clients.showList();
            if ( data == null)
            {
                MessageBox.Show("error en la muestra tabla nula");
            }
            else
            {
                view_tb.DataSource = data.DefaultView; 
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void check_masculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_cc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!queried)
            {
                MessageBox.Show("primero debe consultar el cliente");
            }else if (txt_cc.Text.Trim()=="")
            {
                MessageBox.Show("No puede estar vacio");
            }
            else
            {
                try
                {
                   
                    
                    if (Clients.deleteCLient(txt_cc.Text.Trim()))
                    {
                        queried = false;
                        MessageBox.Show("eliminacion Exitosa");
                        clean();

                    }
                    else
                    {
                        MessageBox.Show("lo sentimos hubo un error, intentelo nuevamente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            listView();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sex_str = "";
            if (check_femenino.Checked)
            {
                sex_str = "FEMENINO";
            }
            else if (check_masculino.Checked)
            {
                sex_str = "MASCULINO";
            }
            else if (check_intersexual.Checked)
            {
                sex_str = "INTERSEXUAL";
            }
            else
            {
                sex_str = "";
            }
            DataTable data = Clients.orderBySex(sex_str);
            if (data == null)
            {
                MessageBox.Show("error en la muestra tabla nula");
            }
            else
            {
                view_tb.DataSource = data.DefaultView;
            }


        }
    }
}