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
    public partial class StateInterview : Form
    {
        SqlCommands cmd = new SqlCommands();
        FillComboValues fcmb = new FillComboValues();
        DummyCombo currQualification = new DummyCombo();
        List<Object> lst;
        bool updated = false;
        string represent_reasons = "";

        public StateInterview()
        {
            InitializeComponent();
            cmd.Catalog = DBCatalog.DB_Tagneed.ToString();
            Init();
            lst = new List<Object>() { rchComplain, drphistIllness, drpfamilyhistIllness, drpBloodSharing,txtSold,txtState,txtWeapon,txtQualification,txtFullName,txtage,txtPreJob,txtState,txtSrcSold,rchInterviewOpinion };
        }
        public void Init()
        {
            fcmb.Recommendations(drpRecommendations);
            fcmb.GetInterviewers(drpInterviewers);

            SelectFirstIndex(new List<Control> {
                drpAwareness,drpBloodSharing,drpDisturbNoticed,drpDisturbThoughts,drpFaceReaction,drpfamilyhistIllness,
                drpFamilyRelationship,drpFinancialStatus,drpFocusAbility, drpFoodDesire,drphistIllness,drpJudegment,drpMotion,
                drpOutfit,drpParentSocialStatus,drpPMood,drpPrayer,drpSleepDesire,drpSmoke,drpStatus,drpTalk,drpTimeRecognize,drpRecommendations
            });
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

     

        public void CheckCheckedItems(List<String> _strList, CheckedListBox chList)
        {
            foreach (var item in _strList)
            {
                var idx = chList.Items.IndexOf(item);
                if (idx >= 0)
                    chList.SetItemChecked(idx, true);
            }
           
        }

        private void ClearControls(List<Object> ctrls)
        {
            foreach (var item in ctrls)
            {
                var _item = (Control)item;
                _item.Text = "";
            }
        }

      
       

        public void CheckAvailabilityToEnter(ComboBox drp, TextBox txt)
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
     

      

       

        private void btnSrch_Click_1(object sender, EventArgs e)
        {
            if (!CheckIfExists())
            {
                var queryBasicInfo = String.Format(@"select sold_id,name,qualification,job,weapon,state,age,social_status from interview where sold_id='{0}'", txtSrcSold.Text);
                cmd.ReaderCMD(queryBasicInfo, _reader =>
                {
                    if (_reader.HasRows)
                    {
                        while (_reader.Read())
                        {
                            txtSold.Text = _reader.GetValue(0).ToString();
                            txtFullName.Text = _reader.GetValue(1).ToString();
                            txtQualification.Text = _reader.GetValue(2).ToString();
                            txtPreJob.Text = _reader.GetValue(3).ToString();
                            txtWeapon.Text = _reader.GetValue(4).ToString();
                            txtState.Text = _reader.GetValue(5).ToString();
                            txtage.Text = _reader.GetValue(6).ToString();
                            drpStatus.Text = _reader.GetValue(7).ToString();
                            txtSavingDate.Text = DateTime.UtcNow.ToShortDateString();
                        }
                        updated = false;
                    }
                    else
                    {
                        MessageBox.Show("تأكد من الرقم العسكري وانه تم تسجيله من قبل !!!");
                    }
                });
            }
            //ChangeResultDrp();
        }
        public bool CheckIfExists()
        {

            var query = String.Format(@"select i.sold_id, name,qualification,job,weapon,state,age ,s.* ,social_status
                                        from syco_interview s  inner join interview i on s.sold_id=i.sold_id  where i.sold_id='{0}'", txtSrcSold.Text);
            var exists = false;
            cmd.ReaderCMD(query, _reader =>
            {
                if (_reader.HasRows)
                {
                    MessageBox.Show("تم اجراء المقابلة من قبل");
                    while (_reader.Read())
                    {
                        txtSold.Text = txtSrcSold.Text;
                        txtFullName.Text = _reader.GetValue(1).ToString();
                        txtQualification.Text = _reader.GetValue(2).ToString();
                        txtPreJob.Text = _reader.GetValue(3).ToString();
                        txtWeapon.Text = _reader.GetValue(4).ToString();
                        txtState.Text = _reader.GetValue(5).ToString();
                        txtage.Text = _reader.GetValue(6).ToString();
                        txtSavingDate.Text = DateTime.UtcNow.ToShortDateString();
                        rchComplain.Text = _reader.GetValue(8).ToString();

                        represent_reasons = _reader.GetValue(9).ToString();


                        drpOutfit.Text = _reader.GetValue(10).ToString();
                        drpTalk.Text = _reader.GetValue(11).ToString();
                        drpMotion.Text = _reader.GetValue(12).ToString();
                        drpPMood.Text = _reader.GetValue(13).ToString();
                        drpFaceReaction.Text = _reader.GetValue(14).ToString();

                        drpFocusAbility.Text = _reader.GetValue(15).ToString();
                        drpTimeRecognize.Text = _reader.GetValue(16).ToString();
                        drpAwareness.Text = _reader.GetValue(17).ToString();
                        drpJudegment.Text = _reader.GetValue(18).ToString();
                        drpDisturbNoticed.Text = _reader.GetValue(19).ToString();
                        drpDisturbThoughts.Text = _reader.GetValue(20).ToString();
                        drpParentSocialStatus.Text = _reader.GetValue(21).ToString();
                        brothers.Value = int.Parse(_reader.GetValue(22).ToString());
                        brothersInLow.Value = int.Parse(_reader.GetValue(23).ToString());
                        range.Value = int.Parse(_reader.GetValue(24).ToString());
                        drpFamilyRelationship.Text = _reader.GetValue(25).ToString();

                        drpFoodDesire.Text = _reader.GetValue(26).ToString();
                        drpSleepDesire.Text = _reader.GetValue(27).ToString();
                        drpPrayer.Text = _reader.GetValue(28).ToString();
                        drpFinancialStatus.Text = _reader.GetValue(29).ToString();
                        drphistIllness.Text = _reader.GetValue(30).ToString();
                        drpfamilyhistIllness.Text = _reader.GetValue(31).ToString();
                        drpBloodSharing.Text = _reader.GetValue(32).ToString();

                        rchInterviewOpinion.Text = _reader.GetValue(33).ToString();
                        rchRecommendations.Text = _reader.GetValue(34).ToString();

                        drpSmoke.Text = _reader.GetValue(35).ToString();
                        drpInterviewers.Text = _reader.GetValue(36).ToString();
                        drpStatus.Text = _reader.GetValue(37).ToString();

                        CheckCheckedItems(_reader.GetValue(9).ToString().Split('\n').ToList(), chkTransReason);
                        CheckCheckedItems(_reader.GetValue(33).ToString().Split('\n').ToList(), checkedListBox1);
                        CheckCheckedItems(_reader.GetValue(33).ToString().Split('\n').ToList(), checkedListBox2);
                        CheckCheckedItems(_reader.GetValue(33).ToString().Split('\n').ToList(), checkedListBox3);


                    }
                    _reader.Close();
                    updated = true;
                    exists = true;
                }
            });
            return exists;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSold.Text != "")
            {
                if (CheckValidations(lst))
                {

                    var query = "";
                    if (!updated)
                    {
                        query = String.Format(@"insert into syco_interview values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}',
                                                                                '{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}',
                                                                                '{21}','{22}','{23}','{24}','{25}','{26}','{27}','{28}','{29}','{30}')",

                         txtSold.Text, rchComplain.Text, represent_reasons,
                         drpOutfit.Text, drpTalk.Text, drpMotion.Text, drpPMood.Text, drpFaceReaction.Text, drpFocusAbility.Text, drpTimeRecognize.Text, drpAwareness.Text,
                         drpJudegment.Text, drpDisturbNoticed.Text, drpDisturbThoughts.Text, drpParentSocialStatus.Text, brothers.Value.ToString(), brothersInLow.Value.ToString(),
                         range.Value.ToString(), drpFamilyRelationship.Text, drpFoodDesire.Text,
                         drpSleepDesire.Text, drpPrayer.Text, drpFinancialStatus.Text, drphistIllness.Text, drpfamilyhistIllness.Text,
                         drpBloodSharing.Text, rchInterviewOpinion.Text, rchRecommendations.Text, drpSmoke.Text, drpInterviewers.Text,DateTime.UtcNow.ToShortDateString());
                    }
                    else
                    {
                        query = String.Format(@"update syco_interview set
                                Complain='{1}',Represent_Reason='{2}',Outfit='{3}',Talk='{4}',Motion='{5}', Mood='{6}',Face_Reactions='{7}',
                                Focus_Ability='{8}',Time_Recognition='{9}',Awareness='{10}',Mental_Judgmental='{11}',Realise_False='{12}',Thinking_False='{13}',Parent_SocialStatus='{14}',
                                Brothers='{15}', Brothers_Inlow='{16}',Range='{17}', Family_Relationship='{18}',Food_Desire='{19}',Sleep_Desire='{20}',Prayer='{21}',Family_FinancialStatus='{22}',
                                History_Illness='{23}',Family_HistoryIllness='{24}', Family_BloodConnection='{25}', Interviewer_opinion='{26}',Recommendations='{27}',Smoking='{28}',Interviewer='{29}'",
                       txtSold.Text, rchComplain.Text, represent_reasons,
                         drpOutfit.Text, drpTalk.Text, drpMotion.Text, drpPMood.Text, drpFaceReaction.Text, drpFocusAbility.Text, drpTimeRecognize.Text, drpAwareness.Text,
                         drpJudegment.Text, drpDisturbNoticed.Text, drpDisturbThoughts.Text, drpParentSocialStatus.Text, brothers.Value.ToString(), brothersInLow.Value.ToString(),
                         range.Value.ToString(), drpFamilyRelationship.Text, drpFoodDesire.Text,
                         drpSleepDesire.Text, drpPrayer.Text, drpFinancialStatus.Text, drphistIllness.Text, drpfamilyhistIllness.Text,
                         drpBloodSharing.Text, rchInterviewOpinion.Text, rchRecommendations.Text, drpSmoke.Text, drpInterviewers.Text);
                    }


                    cmd.GetCMDConnection(query, _cmd =>
                    {
                        var results = _cmd.ExecuteNonQuery();
                        if (results > 0)
                        {
                            MessageBox.Show("تم الحفظ بنجاح");
                            ClearControls(lst);
                        }
                        else MessageBox.Show("من فضلك حاول مرة ثانية بعد التأكد من ادخال كافة البيانات صحيحة");
                    });
                }
            }
            else
            {
                MessageBox.Show("من فضلك حاول مرة ثانية بعد التأكد من ادخال كافة البيانات صحيحة");
            }

        }

        private void chkTransReason_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var srd = (CheckedListBox)sender;
            if (e.NewValue == CheckState.Unchecked)
            {
                represent_reasons = represent_reasons.Replace(srd.SelectedItem + "\n", "");
            }
            else if (e.NewValue == CheckState.Checked)
            {
                represent_reasons += srd.SelectedItem + "\n";
            }

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var srd = (CheckedListBox)sender;

            if (e.NewValue == CheckState.Unchecked)
            {
                rchInterviewOpinion.Text = rchInterviewOpinion.Text.Replace(srd.SelectedItem + "\n", "");
            }
            else if (e.NewValue == CheckState.Checked)
            {
                rchInterviewOpinion.Text += srd.SelectedItem + "\n";
            }
        }

        private void drpRecommendations_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var rcm = (DummyCombo)drpRecommendations.SelectedItem;
            if (rcm.Value == 1)
                rchRecommendations.Text = String.Format(@"يوصي فرع الانتقاء والتوجيه بتحويل المجند المذكور الي مست أحمد جلال للطب النفسي نتيجة لما ظهر عليه من أعراض سابقة الذكر, ويرجي التكرم باجراء فحص نفسي له للتأكد من صحة ادعائه");
            else rchRecommendations.Text = String.Format(@"يوصي فرع الانتقاء والتوجيه بتحويل المجند المذكور الي مست كوبري القبة نظرا لشكواه المرضية حيث أنه يعاني من ..................... ,ويرجي التكرم باجراء فحص طبي له للتأكد من صحة ادعائه");
        }

    }
}