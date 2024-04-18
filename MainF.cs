using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace OracleTest
{
    public partial class MainF : Form
    {
        public MainF()
        {
            InitializeComponent();
        }

        public static OracleConnection oHandle;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string OracleConnectionString = $"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={textBox1.Text})(PORT={textBox2.Text})))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={textBox3.Text})));User ID={textBox4.Text};Password={textBox5.Text};Connection Timeout=30;";

                oHandle = new OracleConnection(OracleConnectionString);

                oHandle.Open();

                if (oHandle.State == ConnectionState.Open)
                {
                    string sTmp = $"Oracle DataBase Access";
                    richTextBox1.AppendText($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] :: {sTmp}\n");

                    for (int nMonth = 1; nMonth <= 12; nMonth++)
                    {
                        for (int nDay = 1; nDay <= 20; nDay++)
                        {
                            String sQuery = $"insert into mealhis(mealdate,mealtime,mealsec,cardno,station,sabeon,issawon,mealflag,mealfee) " +
                                            $"values('2024-{string.Format("{0:00}", nMonth)}-{string.Format("{0:00}", nDay)}'," +
                                            $"'18:25', '59', '1111111121', 'K본관', '22222232', '1', '3', '3300')";

                            richTextBox1.AppendText($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] :: {sQuery}\n");
                            richTextBox1.ScrollToCaret();
                            using (var cmd = new OracleCommand(sQuery, oHandle))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                oHandle.Close();
            }
            catch (OracleException ex)
            {
                richTextBox1.AppendText($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] :: {ex.Message}\n");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (oHandle != null)
            {
                oHandle.Close();
            }

            this.Close();
        }
    }
}
