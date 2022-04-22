using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMain.cs
{
    public partial class FrmDangKy : Form
    {
        private BindingSource bdsLopTC = new BindingSource();
        private BindingSource bdsDSDK = new BindingSource();
        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void FrmDangKy_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.LOPTINCHI' table. You can move, or remove it, as needed.
            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

        }

        private void spinHK_EditValueChanged(object sender, EventArgs e)
        {

        }

   
        private void loadDSTC()
        {
            string cmd = "EXEC [dbo].[SP_DKMH] '" + txtNienKhoa.Text + "', '" + Decimal.ToInt32(spinHK.Value) + "'";
            DataTable dt = Program.ExecSqlDataTable(cmd);
            this.bdsLopTC.DataSource = dt;
            gcDSLTC.DataSource = this.bdsLopTC;
        }
        private void loadDSDDK()
        {
            try
            {
                string cmd = "EXEC [dbo].[SP_GET_DSMH_BY_MASV] '" + txtSV.Text + "','" + txtNienKhoa.Text + "', '" + Decimal.ToInt32(spinHK.Value) + "'";
                DataTable dt = Program.ExecSqlDataTable(cmd);
                this.bdsDSDK.DataSource = dt;
                gcDSDKMH.DataSource = this.bdsDSDK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
          
           
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sINHVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void nIENKHOATextBox_TextChanged(object sender, EventArgs e)
        {

        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtSV.Text != Program.username)
            {
                txtMessage.Text = "Vui lòng nhập đúng mã sinh viên của bạn";
            }
            else
            {
                txtMessage.Text = "HỌ VÀ TÊN:" + Program.mHoten + " ";
            }
        }

        private void btnXacNhan_Click_1(object sender, EventArgs e)
        {if (txtNienKhoa.Text.Trim().Equals(""))
            {
                MessageBox.Show("Niên Khoá không được để trống!", "", MessageBoxButtons.OK);
                txtNienKhoa.Focus();
                return;
            }
            if (Decimal.ToInt32(spinHK.Value) == 0)
            {
                MessageBox.Show("Bạn chưa chọn học kì!", "", MessageBoxButtons.OK);
                spinHK.Focus();
                return;
            }


            this.loadDSTC();
            this.loadDSDDK();
         
        }

        private void gcDSLTC_MouseClick(object sender, MouseEventArgs e)
        {
            if(bdsLopTC.Count > 0)
            {
                 txtMALTC.Text = ((DataRowView)bdsLopTC[bdsLopTC.Position])["MALTC"].ToString();
                  txtMASV.Text = txtSV.Text;

            }
        }

        private void gcDSLTC_Click(object sender, EventArgs e)
        {

        }

        private void btnDKMH_Click(object sender, EventArgs e)
        {
            if(txtMASV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                txtMASV.Focus();
                return;
            }
            if(txtMALTC.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp tín chỉ không được thiếu!", "", MessageBoxButtons.OK);
                txtMALTC.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng kí lớp học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                /*  string cmd = "EXEC [dbo].[SP_REGISTER] '" +Convert.ToInt32(txtMALTC.Text) + "' , '" + txtMASV.Text + "'";
                  if (Program.ExecSqlNonQuery(cmd) == 0)
                  {
                      MessageBox.Show("Đăng kí thành công!");                
                  }
                  else
                  {
                      MessageBox.Show("Đăng kí thất bại");
                  }
              }
              else
              {
                  return;
              }*/
                try
                {
                    string cmd = "EXEC [dbo].[SP_REGISTER] '" + Convert.ToInt32(txtMALTC.Text) + "' , '" + txtMASV.Text + "'";
                   if(Program.ExecSqlNonQuery(cmd) == 1)
                    {
                        MessageBox.Show("Đăng ký thành công");
                        this.loadDSDDK();
                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đăng ký thất bại" + ex.ToString());
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(bdsDSDK.Position < 0)
            {
                MessageBox.Show("Vui lòng chọn lớp tín chỉ muốn huỷ");
                gcDSDKMH.Focus();
                return;

            }
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy đăng kí lớp học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                String MALTC = "";
                if (((DataRowView)bdsDSDK[bdsDSDK.Position])["MALTC"].ToString() != null)
                {
                    MALTC = ((DataRowView)bdsDSDK[bdsDSDK.Position])["MALTC"].ToString();
                }
                MessageBox.Show(MALTC);
                try
                {
                    String cmd = "EXEC [dbo].[SP_HUY_DANGKY_MON] '" + txtSV.Text + "','" + MALTC + "'";
                    if (Program.ExecSqlNonQuery(cmd) == 1)
                    {
                        MessageBox.Show("Huỷ đăng ký thành công");
                        this.loadDSDDK();
                    }
                    else
                    {
                        MessageBox.Show("Xuống đây mẹ rồi nói cc j nữa");

                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else
            {
                return;
            }
        }
    }
}
