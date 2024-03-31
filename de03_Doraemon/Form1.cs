using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de03_Doraemon
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string chuoiketnoi = "Data Source=DESKTOP-GE1C4PK\\SQLEXPRESS;Initial Catalog=truyen;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
        void runcommand(string query)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }
        List<truyen> list;
        void loadData()
        {
            string sql = "Select * from thongtinmuon";
            cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            adapter.SelectCommand = cmd;
            dt.Clear();

            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            loadData();

            list = new List<truyen>()
            {
                new truyen(){ten = "tap1", ngay ="100"},
                new truyen() {ten = "tap2", ngay = "200"},
                new truyen(){ten = "tap3", ngay ="300"},
                new truyen(){ten = "tap4", ngay ="400"}

            };
            cb_tentruyen.DataSource = list;
            cb_tentruyen.DisplayMember = "ten";

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        ulong kq;
        private void btt_muontruyen_Click(object sender, EventArgs e)
        {
            if (!ulong.TryParse(tb_sdt.Text, out kq))
            {
                MessageBox.Show("So dien thoai chua dung", "thong bao");
                tb_sdt.Focus();
                return;
            }
            string query = "INSERT INTO thongtinmuon ([ten khach], [so dien thoai], [ten truyen], [ngay muon], [ghi chu]) " +
                   "VALUES ('" + tb_tenkhach.Text + "', '" + tb_sdt.Text + "', '" + cb_tentruyen.Text + "', '" + ngaymuon.Value.ToString("yyyy-MM-dd") + "', 'chua tra')";

            runcommand(query);
            loadData();


        }
        class truyen
        {
            public string ten { get; set; }
            public string ngay { get; set; }
        }

        private void cb_tentruyen_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedItem != null)
            {
                truyen tr = cb.SelectedItem as truyen;
                tb_đongia.Text = tr.ngay.ToString();
            }
        }

        private void btt_tratruyen_Click(object sender, EventArgs e)
        {
            int tong;
            int i = dataGridView1.CurrentRow.Index;
            DataGridViewRow row = dataGridView1.Rows[i];
            i = (int)row.Cells[0].Value;
           
            tong = Convert.ToInt32(tb_đongia.Text) * (ngaytra.Value - ngaymuon.Value).Days;

            string query = "update thongtinmuon set [thanh tien] =@tong , [ghi chu] = @ghichu , [ngay tra] = @ngaytra where [stt] =@i ";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;

            cmd.Parameters.AddWithValue("@tong", tong);
            cmd.Parameters.AddWithValue("@ghichu", "");
            cmd.Parameters.AddWithValue("@i", i);
            cmd.Parameters.AddWithValue("@ngaytra", ngaytra.Value.ToString("yyyy-MMM-dd"));
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;

                 if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    tb_tenkhach.Text = row.Cells[1].Value.ToString();
                    tb_sdt.Text = row.Cells[2].Value.ToString();
                    cb_tentruyen.Text = row.Cells[3].Value.ToString();
                    ngaymuon.Value = Convert.ToDateTime(row.Cells[4].Value);
                }
        }
    }
}
