using AppSound.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSound.TStates
{
    public partial class BaseInterview : Form
    {
        SqlCommands cmd = new SqlCommands();
        FillComboValues fcmb = new FillComboValues();
        DummyCombo currQualification = new DummyCombo();
        public BaseInterview()
        {
            InitializeComponent();
            cmd.Catalog = DBCatalog.DB_Tagneed.ToString();
            Init();
        }
        public void Init()
        {
            fcmb.RTInterviewerOpnion(drpresults);
            SelectFirstIndex(new List<Control> { drpHosResults, drpSoldSituation, drpConcentrate, drpDrugHistory, drpDrugs, drpFRelationship, drpHosHistory, drpMood, drpPrestiege, drpresults, drpStatus, drpTalkProb });
        }

        public bool CheckValidations(List<Object> sender)
        {
            foreach (var item in sender)
            {
                var _item = (Control)item;
                if (_item.Text == "") return false;
            }
            return true;
        }

        public void SelectFirstIndex(List<Control> cmxs)
        {
            foreach (var item in cmxs)
            {
                var cmx = (ComboBox)item;
                if (cmx.Items.Count > 0)
                {
                    cmx.SelectedIndex = 0;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ctrls = new List<Object> { txtParentWork, txtClinic, txtDrgType, txtFullName, txtNational_id, txtPreJob, txtQualification, txtSold, txtState, txtWeapon, rchComplain };
            if (CheckValidations(ctrls))
            {
                var item = (DummyCombo)drpresults.SelectedItem;
                var query = string.Format(@"update interview set  solider_situation='{0}', interviewer_opinion='{2}' where sold_id='{1}'", drpSoldSituation.Text, txtSrcSold.Text, drpresults.Text);
                
                cmd.GetCMDConnection(query, _cmd =>
                {
                    var results = _cmd.ExecuteNonQuery();
                    if (results > 0)
                    {
                        MessageBox.Show("تم الحفظ");
                        ClearControls(ctrls);
                    }
                });
            }
            else
            {
                MessageBox.Show("عليك ملئ كافة البيانات ");
            }
        }


        public bool CheckIfExists()
        {

            var query = String.Format(@"select * from interview  where sold_id='{0}'", txtSrcSold.Text);
            var exists = false;
            cmd.ReaderCMD(query, _reader =>
            {
                if (_reader.HasRows)
                {
                    MessageBox.Show("تم اجراء المقابلة من قبل");
                    while (_reader.Read())
                    {
                        txtSold.Text = _reader.GetValue(1).ToString();
                        drpPrestiege.Text = _reader.GetValue(2).ToString();
                        txtage.Value = int.Parse(_reader.GetValue(3).ToString());
                        drpConcentrate.Text = _reader.GetValue(4).ToString();
                        drpStatus.Text = _reader.GetValue(5).ToString();
                        txtQualification.Text = _reader.GetValue(6).ToString();
                        txtPreJob.Text = _reader.GetValue(7).ToString();
                        txtWeapon.Text = _reader.GetValue(8).ToString();
                        txtState.Text = _reader.GetValue(9).ToString();
                        txtParentWork.Text = _reader.GetValue(10).ToString();
                        txtBrothers.Value = int.Parse(_reader.GetValue(11).ToString());
                        drpFRelationship.Text = _reader.GetValue(12).ToString();
                        rchComplain.Text = _reader.GetValue(13).ToString();
                        drpMood.Text = _reader.GetValue(14).ToString();
                        drpTalkProb.Text = _reader.GetValue(15).ToString();
                        drpHosHistory.Text = _reader.GetValue(16).ToString();
                        drpDrugs.Text = _reader.GetValue(17).ToString();
                        drpresults.Text = _reader.GetValue(18).ToString();

                        drpSoldSituation.Text = _reader.GetValue(19).ToString();
                        drpHosResults.Text = _reader.GetValue(20).ToString();


                        txtNational_id.Text = _reader.GetValue(21).ToString();
                        txtClinic.Text = _reader.GetValue(22).ToString();
                        txtDrgType.Text = _reader.GetValue(23).ToString();

                        txtFullName.Text = _reader.GetValue(26).ToString();

                    }
                    _reader.Close();
                    exists = true;
                    CheckAvailabilityToEnter(drpHosHistory, txtClinic);
                    CheckAvailabilityToEnter(drpDrugs, txtDrgType);
                }
            });
            return exists;
        }

        private void ClearControls(List<Object> ctrls)
        {
            foreach (var item in ctrls)
            {
                var _item = (Control)item;
                _item.Text = "";
            }
            CheckAvailabilityToEnter(drpHosHistory, txtClinic);
            CheckAvailabilityToEnter(drpDrugs, txtDrgType);
        }

        private void btnSrch_Click(object sender, EventArgs e)
        {
            if (!CheckIfExists())
            {
                var queryBasicInfo = String.Format(@"select sold_id,national_id from interview where sold_id='{0}'", txtSrcSold.Text);
                cmd.ReaderCMD(queryBasicInfo, _reader =>
                {
                    if (_reader.HasRows)
                    {
                        while (_reader.Read())
                        {
                            txtSold.Text = _reader.GetValue(0).ToString();
                            txtNational_id.Text = _reader.GetValue(1).ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("تأكد من الرقم العسكري وانه تم تسجيله من قبل !!!");
                    }
                });
            }
            ChangeResultDrp();
        }

        private void drpHosHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAvailabilityToEnter(drpHosHistory, txtClinic);
        }

        private void drpDrugs_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAvailabilityToEnter(drpDrugs, txtDrgType);
        }

        public void CheckAvailabilityToEnter(ComboBox drp,TextBox txt)
        {
            bool fd = (drp.Text == "لا") ? true : false;
            if (fd)
            {
                txt.Enabled = false;
                txt.Text = "لا";
            }
            else
            {
                txt.Enabled = true;
                txt.Text = "";
            }
        }
        private void drpresults_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeResultDrp();
        }

        private void ChangeResultDrp()
        {
            //var item = (DummyCombo)drpresults.SelectedItem;

            //if (item.Value == 2)
            //{
            //    drpSoldSituation.Enabled = true;
            //    drpHosResults.Enabled = false;
            //}
            //else if (item.Value == 3)
            //{
            //    drpSoldSituation.Enabled = false;
            //    drpHosResults.Enabled = true;
            //}
            //else
            //{
            //    drpSoldSituation.Enabled = drpHosResults.Enabled = false;
            //    drpSoldSituation.Text = drpHosResults.Text = "لا يوجد";
            //}
        }
    }
}
