using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMain.cs
{
    public partial class FrmMonHoc : Form
    {
        int vitri = 0;
        String oldMaMH = "";
        String oldTenMH = "";
        Boolean isSave = true;
        public FrmMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FrmMonHoc_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.LOPTINCHI' table. You can move, or remove it, as needed.
            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            pcMonHoc.Visible = false;
            if(Program.mGroup == "SV")
            {
                btnAdd.Enabled = btnEdit.Enabled = btnSave.Enabled =
                btnUndo.Enabled = btnReload.Enabled = btnDel.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = btnEdit.Enabled = btnReload.Enabled = btnDel.Enabled = true;
                btnSave.Enabled = btnUndo.Enabled = false;
            }
        }

        private void tENMHTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.Control = "add";
            vitri = bdsMonHoc.Position;

            btnAdd.Enabled = btnEdit.Enabled = 
                btnReload.Enabled = btnDel.Enabled =false;
            btnUndo.Enabled = btnSave.Enabled = true;
            gcMonHoc.Enabled = false;
            pcMonHoc.Visible = true;
            pcMonHoc.Enabled = true;
            bdsMonHoc.AddNew();
            txtMAMH.Focus(); 
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.Control = "edit";
            oldMaMH = txtMAMH.Text.Trim().ToString();
            oldTenMH = txtTENMH.Text.Trim().ToString();
            btnAdd.Enabled = btnEdit.Enabled =
               btnReload.Enabled = btnDel.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            pcMonHoc.Enabled = true;
            pcMonHoc.Visible = true;
            vitri = bdsMonHoc.Position;
        }
        private int KiemTraTrung(String strLenh)
        {

            SqlDataReader dataReader = Program.ExecSqlDataReader(strLenh);

            // nếu null thì thoát luôn  ==> lỗi kết nối
            if (dataReader == null)
            {
                return -1;
            }
            dataReader.Read();
            int result = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();
            return result;
        }
        private bool validate()
        {
            if(Program.Control == "add")
            {
                string strLenh = "DECLARE  @return_value int \n"
                          + "EXEC  @return_value = SP_CHECKID \n"
                          + "@Code = N'" + txtMAMH.Text + "',@Type = N'MAMONHOC' \n"
                          + "SELECT  'Return Value' = @return_value ";
                int result = KiemTraTrung(strLenh);
                if(txtMAMH.Text.Trim() == "")
                {
                    MessageBox.Show("Mã môn học không được để trống!", "", MessageBoxButtons.OK);
                    txtMAMH.Focus();
                    isSave = false;
                    return false;
                }
                if (result != 0)
                {
                    MessageBox.Show("Mã môn học đã tồn tại!", "", MessageBoxButtons.OK);
                    txtMAMH.Focus();
                    isSave = false;
                    return false;
                }
                if(txtTENMH.Text.Trim() == "")
                {
                    MessageBox.Show("Tên môn học không được để trống!", "", MessageBoxButtons.OK);
                    txtTENMH.Focus();
                    isSave = false;
                    return false;
                }
                string strLenh1 = "DECLARE @return_value int \n"
                                  + "EXEC @return_value = SP_CHECKNAME \n"
                                  + "@Name = N'" + txtTENMH.Text + "', @Type = N'TENMONHOC' \n"
                                  + "SELECT 'Return Value' = @return_value ";
                int result1 = KiemTraTrung(strLenh1);
                if(result1 != 0)
                {
                    MessageBox.Show("Tên môn học đã tồn tại!", "", MessageBoxButtons.OK);
                    txtTENMH.Focus();
                    isSave = false;
                    return false;
                }
                if (txtLT.Text.Trim().ToString() == "")
                {
                    MessageBox.Show("Không được để trống số môn lý thuyết!", "", MessageBoxButtons.OK);
                    txtLT.Focus();
                    isSave = false;
                    return false;
                }
                Regex nonNumericRegex = new Regex(@"\D");
                if (nonNumericRegex.IsMatch(txtLT.Text)) 
                {
                    MessageBox.Show("Kiểu dữ liệu không hợp lệ!", "", MessageBoxButtons.OK);
                    txtLT.Focus();
                    isSave = false;
                    return false;
                }
                if (txtTH.Text.Trim().ToString() == "")
                {
                    MessageBox.Show("Không được để trống số tiết lý thuyết!", "", MessageBoxButtons.OK);
                    txtTH.Focus();
                    isSave = false;
                    return false;
                }
               
                if (nonNumericRegex.IsMatch(txtTH.Text))
                {
                    MessageBox.Show("Kiểu dữ liệu không hợp lệ!", "", MessageBoxButtons.OK);
                    txtTH.Focus();
                    isSave = false;
                    return false;
                }
            }
            else if(Program.Control =="edit"){
                if (!txtMAMH.Text.Trim().ToString().Equals(oldMaMH))
                {
                    string strLenh = "DECLARE  @return_value int \n"
                         + "EXEC  @return_value = SP_CHECKID \n"
                         + "@Code = N'" + txtMAMH.Text + "',@Type = N'MALOP' \n"
                         + "SELECT  'Return Value' = @return_value ";
                    int result = KiemTraTrung(strLenh);
                    if (result != 0)
                    {
                        MessageBox.Show("Mã môn học đã tồn tại!", "", MessageBoxButtons.OK);
                        txtMAMH.Focus();
                        isSave = false;
                        return false;
                    }

                }else if (!txtTENMH.Text.Trim().ToString().Equals(oldTenMH))
                {
                    string strLenh1 = "DECLARE @return_value int \n"
                                  + "EXEC @return_value = SP_CHECKNAME \n"
                                  + "@Name = N'" + txtTENMH.Text + "', @Type = N'TENMONHOC' \n"
                                  + "SELECT 'Return Value' = @return_value ";
                    int result1 = KiemTraTrung(strLenh1);
                    if (result1 != 0)
                    {
                        MessageBox.Show("Tên môn học đã tồn tại!", "", MessageBoxButtons.OK);
                        txtTENMH.Focus();
                        isSave = false;
                        return false;
                    }
                }

            }
            return true;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (validate())
            {
                try
                {
                    bdsMonHoc.EndEdit();
                    bdsMonHoc.ResetCurrentItem();
                    this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                    if(Program.Control == "add")
                    {
                        bdsMonHoc.MoveLast();
                    }else if(Program.Control == "edit")
                    {
                        bdsMonHoc.Position = vitri;
                    }
                    gcMonHoc.Enabled = true;
                    btnAdd.Enabled = btnEdit.Enabled = btnDel.Enabled = btnReload.Enabled = btnExit.Enabled = true;
                    btnSave.Enabled = btnUndo.Enabled = false;

                    pcMonHoc.Visible = false;
                    pcMonHoc.Enabled = false;
                    MessageBox.Show("Ghi thành công", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    bdsMonHoc.RemoveCurrent();
                    MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
                }
            }
            if(isSave == true)
            {
                Program.Control = "";
            }
          
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void txtMAMH_TextChanged(object sender, EventArgs e)
        {
            txtMAMH.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMonHoc.CancelEdit();
            if(btnAdd.Enabled == false)
            {
                bdsMonHoc.Position = vitri;
            }
            gcMonHoc.Enabled = true;
            btnAdd.Enabled = btnEdit.Enabled = btnDel.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;

            pcMonHoc.Enabled = false;
            pcMonHoc.Visible = false;


        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(bdsLopTC.Count> 0)
            {
                MessageBox.Show("Không thể xoá môn học vì đã tồn tại trong lớp: ", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá môn này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    vitri = bdsMonHoc.Position;
                    bdsMonHoc.RemoveCurrent();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi xoá môn. Bạn hãy xoá lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                    bdsMonHoc.Position = vitri;
                    return;
                }
            }
            if (bdsMonHoc.Count == 0) btnDel.Enabled = false;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
