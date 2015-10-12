using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon_Rush_Team_Builder
{
    public partial class Form1 : Form
    {
        double powTMone = 0;
        double powTMtwo = 0;
        double powTMthree = 0;
        double powTMfour = 0;
        double powTMfive = 0;
        double powTMsix = 0;
        double powTMtotal = 0;
        double powApproxTotal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'creature_DatabaseDataSet.Legendary' table. You can move, or remove it, as needed.
            this.legendaryTableAdapter.Fill(this.creature_DatabaseDataSet.Legendary);

        }

        /*To Solve: Approximate power total broke somewhere in all the changes this thing has taken. Instead of adding the
         *rough average for each person, it only adds that average once. The fix is to make it add that bonus per member added,
         *probably via one of the variables class variables, by scanning for however many charaters are set and multiplying. 
         *This isn't hard to do, I'm just too lazy atm. */

        private void btnTMone_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstTMchooser.SelectedValue != null)
                {
                    string ab1 = "";
                    int ab2, ab3, ab4;
                    int id = int.Parse(lstTMchooser.SelectedValue.ToString());
                    lblTMone.Text = creature_DatabaseDataSet.Tables[0].Rows[id - 1].ItemArray[1].ToString();
                    lsvTMone.Items.Clear();
                    ListViewItem item1, item2, item3, item4, item5, item6, item7;
                    PopulateSub(out item1, out item2, out item3, out item4, out item5, out item6, out item7);
                    lsvTMone.Items.AddRange(new ListViewItem[] { item1, item2, item3, item4, item5, item6, item7 });
                    powTMone = double.Parse(creature_DatabaseDataSet.Tables[0].Rows[id - 1].ItemArray[4].ToString());
                    powTMtotal = powTMone + powTMtwo + powTMthree + powTMfour + powTMfive + powTMsix;
                    txtPowCnt.Text = powTMtotal.ToString();
                    powApproxTotal = powTMtotal + 27000;
                    txtApproxPower.Text = powApproxTotal.ToString();
                    AbilityFinder(out ab1, out ab2, out ab3, out ab4);
                    Variables.TMoneFaction = ab1;
                    Variables.TMoneAFind1 = ab2;
                    Variables.TMoneAFind2 = ab3;
                    Variables.TMoneAFind3 = ab4;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Bad things happened");
                lstTMchooser.Focus();
            }
        }

        private void btnTMtwo_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstTMchooser.SelectedValue != null)
                {
                    string ab1 = "";
                    int ab2, ab3, ab4;
                    int id = int.Parse(lstTMchooser.SelectedValue.ToString());
                    lblTMtwo.Text = creature_DatabaseDataSet.Tables[0].Rows[id - 1].ItemArray[1].ToString();
                    lsvTMtwo.Items.Clear();
                    ListViewItem item1, item2, item3, item4, item5, item6, item7;
                    PopulateSub(out item1, out item2, out item3, out item4, out item5, out item6, out item7);
                    lsvTMtwo.Items.AddRange(new ListViewItem[] { item1, item2, item3, item4, item5, item6, item7 });
                    powTMtwo = double.Parse(creature_DatabaseDataSet.Tables[0].Rows[id - 1].ItemArray[4].ToString());
                    powTMtotal = powTMone + powTMtwo + powTMthree + powTMfour + powTMfive + powTMsix;
                    txtPowCnt.Text = powTMtotal.ToString();
                    powApproxTotal = powTMtotal + 27000;
                    txtApproxPower.Text = powApproxTotal.ToString();
                    AbilityFinder(out ab1, out ab2, out ab3, out ab4);
                    Variables.TMtwoFaction = ab1;
                    Variables.TMtwoAFind1 = ab2;
                    Variables.TMtwoAFind2 = ab3;
                    Variables.TMtwoAFind3 = ab4;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Bad things happened");
                lstTMchooser.Focus();
            }
        }

        private void btnTMthree_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstTMchooser.SelectedValue != null)
                {
                    string ab1 = "";
                    int ab2, ab3, ab4;
                    int id = int.Parse(lstTMchooser.SelectedValue.ToString());
                    lblTMthree.Text = creature_DatabaseDataSet.Tables[0].Rows[id - 1].ItemArray[1].ToString();
                    lsvTMthree.Items.Clear();
                    ListViewItem item1, item2, item3, item4, item5, item6, item7;
                    PopulateSub(out item1, out item2, out item3, out item4, out item5, out item6, out item7);
                    lsvTMthree.Items.AddRange(new ListViewItem[] { item1, item2, item3, item4, item5, item6, item7 });
                    powTMthree = double.Parse(creature_DatabaseDataSet.Tables[0].Rows[id - 1].ItemArray[4].ToString());
                    powTMtotal = powTMone + powTMtwo + powTMthree + powTMfour + powTMfive + powTMsix;
                    txtPowCnt.Text = powTMtotal.ToString();
                    powApproxTotal = powTMtotal + 27000;
                    txtApproxPower.Text = powApproxTotal.ToString();
                    AbilityFinder(out ab1, out ab2, out ab3, out ab4);
                    Variables.TMthreeFaction = ab1;
                    Variables.TMthreeAFind1 = ab2;
                    Variables.TMthreeAFind2 = ab3;
                    Variables.TMthreeAFind3 = ab4;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Bad things happened");
                lstTMchooser.Focus();
            }
        }

        private void btnTMfour_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstTMchooser.SelectedValue != null)
                {
                    string ab1 = "";
                    int ab2, ab3, ab4;
                    int id = int.Parse(lstTMchooser.SelectedValue.ToString());
                    lblTMfour.Text = creature_DatabaseDataSet.Tables[0].Rows[id - 1].ItemArray[1].ToString();
                    lsvTMfour.Items.Clear();
                    ListViewItem item1, item2, item3, item4, item5, item6, item7;
                    PopulateSub(out item1, out item2, out item3, out item4, out item5, out item6, out item7);
                    lsvTMfour.Items.AddRange(new ListViewItem[] { item1, item2, item3, item4, item5, item6, item7 });
                    powTMfour = double.Parse(creature_DatabaseDataSet.Tables[0].Rows[id - 1].ItemArray[4].ToString());
                    powTMtotal = powTMone + powTMtwo + powTMthree + powTMfour + powTMfive + powTMsix;
                    txtPowCnt.Text = powTMtotal.ToString();
                    powApproxTotal = powTMtotal + 27000;
                    txtApproxPower.Text = powApproxTotal.ToString();
                    AbilityFinder(out ab1, out ab2, out ab3, out ab4);
                    Variables.TMfourFaction = ab1;
                    Variables.TMfourAFind1 = ab2;
                    Variables.TMfourAFind2 = ab3;
                    Variables.TMfourAFind3 = ab4;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Bad things happened");
                lstTMchooser.Focus();
            }
        }

        private void btnTMfive_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstTMchooser.SelectedValue != null)
                {
                    string ab1 = "";
                    int ab2, ab3, ab4;
                    int id = int.Parse(lstTMchooser.SelectedValue.ToString());
                    lblTMfive.Text = creature_DatabaseDataSet.Tables[0].Rows[id - 1].ItemArray[1].ToString();
                    lsvTMfive.Items.Clear();
                    ListViewItem item1, item2, item3, item4, item5, item6, item7;
                    PopulateSub(out item1, out item2, out item3, out item4, out item5, out item6, out item7);
                    lsvTMfive.Items.AddRange(new ListViewItem[] { item1, item2, item3, item4, item5, item6, item7 });
                    powTMfive = double.Parse(creature_DatabaseDataSet.Tables[0].Rows[id - 1].ItemArray[4].ToString());
                    powTMtotal = powTMone + powTMtwo + powTMthree + powTMfour + powTMfive + powTMsix;
                    txtPowCnt.Text = powTMtotal.ToString();
                    powApproxTotal = powTMtotal + 27000;
                    txtApproxPower.Text = powApproxTotal.ToString();
                    AbilityFinder(out ab1, out ab2, out ab3, out ab4);
                    Variables.TMfiveFaction = ab1;
                    Variables.TMfiveAFind1 = ab2;
                    Variables.TMfiveAFind2 = ab3;
                    Variables.TMfiveAFind3 = ab4;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Bad things happened");
                lstTMchooser.Focus();
            }
        }

        private void btnTMsix_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstTMchooser.SelectedValue != null)
                {
                    string ab1 = "";
                    int ab2, ab3, ab4;
                    int id = int.Parse(lstTMchooser.SelectedValue.ToString());
                    lblTMsix.Text = creature_DatabaseDataSet.Tables[0].Rows[id - 1].ItemArray[1].ToString();
                    lsvTMsix.Items.Clear();
                    ListViewItem item1, item2, item3, item4, item5, item6, item7;
                    PopulateSub(out item1, out item2, out item3, out item4, out item5, out item6, out item7);
                    lsvTMsix.Items.AddRange(new ListViewItem[] { item1, item2, item3, item4, item5, item6, item7 });
                    powTMsix = double.Parse(creature_DatabaseDataSet.Tables[0].Rows[id - 1].ItemArray[4].ToString());
                    powTMtotal = powTMone + powTMtwo + powTMthree + powTMfour + powTMfive + powTMsix;
                    txtPowCnt.Text = powTMtotal.ToString();
                    powApproxTotal = powTMtotal + 27000;
                    txtApproxPower.Text = powApproxTotal.ToString();
                    AbilityFinder(out ab1, out ab2, out ab3, out ab4);
                    Variables.TMsixFaction = ab1;
                    Variables.TMsixAFind1 = ab2;
                    Variables.TMsixAFind2 = ab3;
                    Variables.TMsixAFind3 = ab4;
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Bad things happened");
                lstTMchooser.Focus();
            }
        }

        private void btnACalc_Click(object sender, EventArgs e) //The eventual purpose for this is to calculate effective power totals for each member once faction ability bonii are factored in. This hinges on cracking the math behind the power formula, so for the time being it's just a tracker for the faction bonus.
        {
            int trap = int.Parse(txtPowCnt.Text.ToString());
            if (trap > 0)
            {
                ResetAbilityCalc();
                int tempTMB = 0;
                int memEvil = 0, memBas = 0, memCha = 0, memForest = 0, memLight = 0, memDark = 0;
                string TMoneA1Name = Variables.AbilityNames[Variables.TMoneAFind1], TMoneA2Name = Variables.AbilityNames[Variables.TMoneAFind2], TMoneA3Name = Variables.AbilityNames[Variables.TMoneAFind3];
                string TMtwoA1Name = Variables.AbilityNames[Variables.TMtwoAFind1], TMtwoA2Name = Variables.AbilityNames[Variables.TMtwoAFind2], TMtwoA3Name = Variables.AbilityNames[Variables.TMtwoAFind3];
                string TMthreeA1Name = Variables.AbilityNames[Variables.TMthreeAFind1], TMthreeA2Name = Variables.AbilityNames[Variables.TMthreeAFind2], TMthreeA3Name = Variables.AbilityNames[Variables.TMthreeAFind3];
                string TMfourA1Name = Variables.AbilityNames[Variables.TMfourAFind1], TMfourA2Name = Variables.AbilityNames[Variables.TMfourAFind2], TMfourA3Name = Variables.AbilityNames[Variables.TMfourAFind3];
                string TMfiveA1Name = Variables.AbilityNames[Variables.TMfiveAFind1], TMfiveA2Name = Variables.AbilityNames[Variables.TMfiveAFind2], TMfiveA3Name = Variables.AbilityNames[Variables.TMfiveAFind3];
                string TMsixA1Name = Variables.AbilityNames[Variables.TMsixAFind1], TMsixA2Name = Variables.AbilityNames[Variables.TMsixAFind2], TMsixA3Name = Variables.AbilityNames[Variables.TMsixAFind3];
                //Here is where we're tracking whether or not a faction appears in the team. This is relevant for the output later.
                if (Variables.TMoneFaction == "Evil" || Variables.TMtwoFaction == "Evil" || Variables.TMthreeFaction == "Evil" || Variables.TMfourFaction == "Evil" || Variables.TMfiveFaction == "Evil" || Variables.TMsixFaction == "Evil")
                    memEvil++;
                if (Variables.TMoneFaction == "Bastion" || Variables.TMtwoFaction == "Bastion" || Variables.TMthreeFaction == "Bastion" || Variables.TMfourFaction == "Bastion" || Variables.TMfiveFaction == "Bastion" || Variables.TMsixFaction == "Bastion")
                    memBas++;
                if (Variables.TMoneFaction == "Chaos" || Variables.TMtwoFaction == "Chaos" || Variables.TMthreeFaction == "Chaos" || Variables.TMfourFaction == "Chaos" || Variables.TMfiveFaction == "Chaos" || Variables.TMsixFaction == "Chaos")
                    memCha++;
                if (Variables.TMoneFaction == "Forest" || Variables.TMtwoFaction == "Forest" || Variables.TMthreeFaction == "Forest" || Variables.TMfourFaction == "Forest" || Variables.TMfiveFaction == "Forest" || Variables.TMsixFaction == "Forest")
                    memForest++;
                if (Variables.TMoneFaction == "Light" || Variables.TMtwoFaction == "Light" || Variables.TMthreeFaction == "Light" || Variables.TMfourFaction == "Light" || Variables.TMfiveFaction == "Light" || Variables.TMsixFaction == "Light")
                    memLight++;
                if (Variables.TMoneFaction == "Dark" || Variables.TMtwoFaction == "Dark" || Variables.TMthreeFaction == "Dark" || Variables.TMfourFaction == "Dark" || Variables.TMfiveFaction == "Dark" || Variables.TMsixFaction == "Dark")
                    memDark++;
                //Now we read the ability containing variables to find out if team members have any of the abilities we're looking for.
                if (Variables.TMoneAFind1 > 0)
                {
                    tempTMB = Variables.TMoneAFind1;
                    lstAbility.Items.Add("Member 1: " + lblTMone.Text + " has " + TMoneA1Name);
                    GetAbilityBonus(tempTMB);
                }
                if (Variables.TMoneAFind2 > 0)
                {
                    tempTMB = Variables.TMoneAFind2;
                    lstAbility.Items.Add("Member 1: " + lblTMone.Text + " has " + TMoneA2Name);
                    GetAbilityBonus(tempTMB);
                }
                if (Variables.TMoneAFind3 > 0)
                {
                    tempTMB = Variables.TMoneAFind3;
                    lstAbility.Items.Add("Member 1: " + lblTMone.Text + " has " + TMoneA3Name);
                    GetAbilityBonus(tempTMB);
                }
                if (Variables.TMtwoAFind1 > 0)
                {
                    tempTMB = Variables.TMtwoAFind1;
                    lstAbility.Items.Add("Member 2: " + lblTMtwo.Text + " has " + TMtwoA1Name);
                    GetAbilityBonus(tempTMB);
                }
                if (Variables.TMtwoAFind2 > 0)
                {
                    tempTMB = Variables.TMtwoAFind2;
                    lstAbility.Items.Add("Member 2: " + lblTMtwo.Text + " has " + TMtwoA2Name);
                    GetAbilityBonus(tempTMB);
                }
                if (Variables.TMtwoAFind3 > 0)
                {
                    tempTMB = Variables.TMtwoAFind3;
                    lstAbility.Items.Add("Member 2: " + lblTMtwo.Text + " has " + TMtwoA3Name);
                    GetAbilityBonus(tempTMB);
                }
                if (Variables.TMthreeAFind1 > 0)
                {
                    tempTMB = Variables.TMthreeAFind1;
                    lstAbility.Items.Add("Member 3: " + lblTMthree.Text + " has " + TMthreeA1Name);
                    GetAbilityBonus(tempTMB);
                }
                if (Variables.TMthreeAFind2 > 0)
                {
                    tempTMB = Variables.TMthreeAFind2;
                    lstAbility.Items.Add("Member 3: " + lblTMthree.Text + " has " + TMthreeA2Name);
                    GetAbilityBonus(tempTMB);
                }
                if (Variables.TMthreeAFind3 > 0)
                {
                    tempTMB = Variables.TMthreeAFind3;
                    lstAbility.Items.Add("Member 3: " + lblTMthree.Text + " has " + TMthreeA3Name);
                    GetAbilityBonus(tempTMB);
                }
                if (Variables.TMfourAFind1 > 0)
                {
                    tempTMB = Variables.TMfourAFind1;
                    lstAbility.Items.Add("Member 4: " + lblTMfour.Text + " has " + TMfourA1Name);
                    GetAbilityBonus(tempTMB);
                }
                if (Variables.TMfourAFind2 > 0)
                {
                    tempTMB = Variables.TMfourAFind2;
                    lstAbility.Items.Add("Member 4: " + lblTMfour.Text + " has " + TMfourA2Name);
                    GetAbilityBonus(tempTMB);
                }
                if (Variables.TMfourAFind3 > 0)
                {
                    tempTMB = Variables.TMfourAFind3;
                    lstAbility.Items.Add("Member 4: " + lblTMfour.Text + " has " + TMfourA3Name);
                    GetAbilityBonus(tempTMB);
                }
                if (Variables.TMfiveAFind1 > 0)
                {
                    tempTMB = Variables.TMfiveAFind1;
                    lstAbility.Items.Add("Member 5: " + lblTMfive.Text + " has " + TMfiveA1Name);
                    GetAbilityBonus(tempTMB);
                }
                if (Variables.TMfiveAFind2 > 0)
                {
                    tempTMB = Variables.TMfiveAFind2;
                    lstAbility.Items.Add("Member 5: " + lblTMfive.Text + " has " + TMfiveA2Name);
                    GetAbilityBonus(tempTMB);
                }
                if (Variables.TMfiveAFind3 > 0)
                {
                    tempTMB = Variables.TMfiveAFind3;
                    lstAbility.Items.Add("Member 5: " + lblTMfive.Text + " has " + TMfiveA3Name);
                    GetAbilityBonus(tempTMB);
                }
                if (Variables.TMsixAFind1 > 0)
                {
                    tempTMB = Variables.TMsixAFind1;
                    lstAbility.Items.Add("Member 1: " + lblTMsix.Text + " has " + TMsixA1Name);
                    GetAbilityBonus(tempTMB);
                }
                if (Variables.TMsixAFind2 > 0)
                {
                    tempTMB = Variables.TMsixAFind2;
                    lstAbility.Items.Add("Member 6: " + lblTMsix.Text + " has " + TMsixA2Name);
                    GetAbilityBonus(tempTMB);
                }
                if (Variables.TMsixAFind3 > 0)
                {
                    tempTMB = Variables.TMsixAFind3;
                    lstAbility.Items.Add("Member 6: " + lblTMsix.Text + " has " + TMsixA3Name);
                    GetAbilityBonus(tempTMB);
                }
                //This generates the final output per faction, with team members and the total bonus per faction.
                if (memEvil > 0)
                {
                    lstAbility2.Items.Add("Evil Faction Team Members");
                    if (Variables.TMoneFaction == "Evil")
                        lstAbility2.Items.Add("--" + lblTMone.Text);
                    if (Variables.TMtwoFaction == "Evil")
                        lstAbility2.Items.Add("--" + lblTMtwo.Text);
                    if (Variables.TMthreeFaction == "Evil")
                        lstAbility2.Items.Add("--" + lblTMthree.Text);
                    if (Variables.TMfourFaction == "Evil")
                        lstAbility2.Items.Add("--" + lblTMfour.Text);
                    if (Variables.TMfiveFaction == "Evil")
                        lstAbility2.Items.Add("--" + lblTMfive.Text);
                    if (Variables.TMsixFaction == "Evil")
                        lstAbility2.Items.Add("--" + lblTMsix.Text);
                    lstAbility2.Items.Add("Evil Faction Bonuses");
                    if (Variables.bonusEvilLife > 0)
                        lstAbility2.Items.Add("Life bonus: +" + Variables.bonusEvilLife + "%");
                    if (Variables.bonusEvilAtk > 0)
                        lstAbility2.Items.Add("Attack bonus: +" + Variables.bonusEvilAtk + "%");
                    if (Variables.bonusEvilAr > 0)
                        lstAbility2.Items.Add("Armor bonus: +" + Variables.bonusEvilAr + "%");
                    if (Variables.bonusEvilSpd > 0)
                        lstAbility2.Items.Add("Speed bonus: +" + Variables.bonusEvilSpd + "%");
                    if (Variables.bonusEvilCDam > 0)
                        lstAbility2.Items.Add("Critical Damage bonus: +" + Variables.bonusEvilCDam + "%");
                    if (Variables.bonusEvilRed > 0)
                        lstAbility2.Items.Add("Damage Reduction bonus: +" + Variables.bonusEvilRed + "%");
                }
                if (memBas > 0)
                {
                    lstAbility2.Items.Add("Bastion Faction Team Members");
                    if (Variables.TMoneFaction == "Bastion")
                        lstAbility2.Items.Add("--" + lblTMone.Text);
                    if (Variables.TMtwoFaction == "Bastion")
                        lstAbility2.Items.Add("--" + lblTMtwo.Text);
                    if (Variables.TMthreeFaction == "Bastion")
                        lstAbility2.Items.Add("--" + lblTMthree.Text);
                    if (Variables.TMfourFaction == "Bastion")
                        lstAbility2.Items.Add("--" + lblTMfour.Text);
                    if (Variables.TMfiveFaction == "Bastion")
                        lstAbility2.Items.Add("--" + lblTMfive.Text);
                    if (Variables.TMsixFaction == "Bastion")
                        lstAbility2.Items.Add("--" + lblTMsix.Text);
                    lstAbility2.Items.Add("Bastion Faction Bonuses");
                    if (Variables.bonusBasLife > 0)
                        lstAbility2.Items.Add("Life bonus: +" + Variables.bonusBasLife + "%");
                    if (Variables.bonusBasAtk > 0)
                        lstAbility2.Items.Add("Attack bonus: +" + Variables.bonusBasAtk + "%");
                    if (Variables.bonusBasAr > 0)
                        lstAbility2.Items.Add("Armor bonus: +" + Variables.bonusBasAr + "%");
                    if (Variables.bonusBasSpd > 0)
                        lstAbility2.Items.Add("Speed bonus: +" + Variables.bonusBasSpd + "%");
                    if (Variables.bonusBasCDam > 0)
                        lstAbility2.Items.Add("Critical Damage bonus: +" + Variables.bonusBasCDam + "%");
                    if (Variables.bonusBasRed > 0)
                        lstAbility2.Items.Add("Damage Reduction bonus: +" + Variables.bonusBasRed + "%");
                }
                if (memCha > 0)
                {
                    lstAbility2.Items.Add("Chaos Faction Team Members");
                    if (Variables.TMoneFaction == "Chaos")
                        lstAbility2.Items.Add("--" + lblTMone.Text);
                    if (Variables.TMtwoFaction == "Chaos")
                        lstAbility2.Items.Add("--" + lblTMtwo.Text);
                    if (Variables.TMthreeFaction == "Chaos")
                        lstAbility2.Items.Add("--" + lblTMthree.Text);
                    if (Variables.TMfourFaction == "Chaos")
                        lstAbility2.Items.Add("--" + lblTMfour.Text);
                    if (Variables.TMfiveFaction == "Chaos")
                        lstAbility2.Items.Add("--" + lblTMfive.Text);
                    if (Variables.TMsixFaction == "Chaos")
                        lstAbility2.Items.Add("--" + lblTMsix.Text);
                    lstAbility2.Items.Add("Evil Faction Bonuses");
                    if (Variables.bonusChaLife > 0)
                        lstAbility2.Items.Add("Life bonus: +" + Variables.bonusChaLife + "%");
                    if (Variables.bonusChaAtk > 0)
                        lstAbility2.Items.Add("Attack bonus: +" + Variables.bonusChaAtk + "%");
                    if (Variables.bonusChaAr > 0)
                        lstAbility2.Items.Add("Armor bonus: +" + Variables.bonusChaAr + "%");
                    if (Variables.bonusChaSpd > 0)
                        lstAbility2.Items.Add("Speed bonus: +" + Variables.bonusChaSpd + "%");
                    if (Variables.bonusChaCDam > 0)
                        lstAbility2.Items.Add("Critical Damage bonus: +" + Variables.bonusChaCDam + "%");
                    if (Variables.bonusChaRed > 0)
                        lstAbility2.Items.Add("Damage Reduction bonus: +" + Variables.bonusChaRed + "%");
                }
                if (memForest > 0)
                {
                    lstAbility2.Items.Add("Forest Faction Team Members");
                    if (Variables.TMoneFaction == "Forest")
                        lstAbility2.Items.Add("--" + lblTMone.Text);
                    if (Variables.TMtwoFaction == "Forest")
                        lstAbility2.Items.Add("--" + lblTMtwo.Text);
                    if (Variables.TMthreeFaction == "Forest")
                        lstAbility2.Items.Add("--" + lblTMthree.Text);
                    if (Variables.TMfourFaction == "Forest")
                        lstAbility2.Items.Add("--" + lblTMfour.Text);
                    if (Variables.TMfiveFaction == "Forest")
                        lstAbility2.Items.Add("--" + lblTMfive.Text);
                    if (Variables.TMsixFaction == "Forest")
                        lstAbility2.Items.Add("--" + lblTMsix.Text);
                    lstAbility2.Items.Add("Forest Faction Bonuses");
                    if (Variables.bonusForestLife > 0)
                        lstAbility2.Items.Add("Life bonus: +" + Variables.bonusForestLife + "%");
                    if (Variables.bonusForestAtk > 0)
                        lstAbility2.Items.Add("Attack bonus: +" + Variables.bonusForestAtk + "%");
                    if (Variables.bonusForestAr > 0)
                        lstAbility2.Items.Add("Armor bonus: +" + Variables.bonusForestAr + "%");
                    if (Variables.bonusForestSpd > 0)
                        lstAbility2.Items.Add("Speed bonus: +" + Variables.bonusForestSpd + "%");
                    if (Variables.bonusForestCDam > 0)
                        lstAbility2.Items.Add("Critical Damage bonus: +" + Variables.bonusForestCDam + "%");
                    if (Variables.bonusForestRed > 0)
                        lstAbility2.Items.Add("Damage Reduction bonus: +" + Variables.bonusForestRed + "%");
                }
                if (memLight > 0)
                {
                    lstAbility2.Items.Add("Light Faction Team Members");
                    if (Variables.TMoneFaction == "Light")
                        lstAbility2.Items.Add("--" + lblTMone.Text);
                    if (Variables.TMtwoFaction == "Light")
                        lstAbility2.Items.Add("--" + lblTMtwo.Text);
                    if (Variables.TMthreeFaction == "Light")
                        lstAbility2.Items.Add("--" + lblTMthree.Text);
                    if (Variables.TMfourFaction == "Light")
                        lstAbility2.Items.Add("--" + lblTMfour.Text);
                    if (Variables.TMfiveFaction == "Light")
                        lstAbility2.Items.Add("--" + lblTMfive.Text);
                    if (Variables.TMsixFaction == "Light")
                        lstAbility2.Items.Add("--" + lblTMsix.Text);
                    lstAbility2.Items.Add("Light Faction Bonuses");
                    if (Variables.bonusLightLife > 0)
                        lstAbility2.Items.Add("Life bonus: +" + Variables.bonusLightLife + "%");
                    if (Variables.bonusLightAtk > 0)
                        lstAbility2.Items.Add("Attack bonus: +" + Variables.bonusLightAtk + "%");
                    if (Variables.bonusLightAr > 0)
                        lstAbility2.Items.Add("Armor bonus: +" + Variables.bonusLightAr + "%");
                    if (Variables.bonusLightSpd > 0)
                        lstAbility2.Items.Add("Speed bonus: +" + Variables.bonusLightSpd + "%");
                    if (Variables.bonusLightCDam > 0)
                        lstAbility2.Items.Add("Critical Damage bonus: +" + Variables.bonusLightCDam + "%");
                    if (Variables.bonusLightRed > 0)
                        lstAbility2.Items.Add("Damage Reduction bonus: +" + Variables.bonusLightRed + "%");
                }
                if (memDark > 0)
                {
                    lstAbility2.Items.Add("Dark Faction Team Members");
                    if (Variables.TMoneFaction == "Dark")
                        lstAbility2.Items.Add("--" + lblTMone.Text);
                    if (Variables.TMtwoFaction == "Dark")
                        lstAbility2.Items.Add("--" + lblTMtwo.Text);
                    if (Variables.TMthreeFaction == "Dark")
                        lstAbility2.Items.Add("--" + lblTMthree.Text);
                    if (Variables.TMfourFaction == "Dark")
                        lstAbility2.Items.Add("--" + lblTMfour.Text);
                    if (Variables.TMfiveFaction == "Dark")
                        lstAbility2.Items.Add("--" + lblTMfive.Text);
                    if (Variables.TMsixFaction == "Dark")
                        lstAbility2.Items.Add("--" + lblTMsix.Text);
                    lstAbility2.Items.Add("Dark Faction Bonuses");
                    if (Variables.bonusDarkLife > 0)
                        lstAbility2.Items.Add("Life bonus: +" + Variables.bonusDarkLife + "%");
                    if (Variables.bonusDarkAtk > 0)
                        lstAbility2.Items.Add("Attack bonus: +" + Variables.bonusDarkAtk + "%");
                    if (Variables.bonusDarkAr > 0)
                        lstAbility2.Items.Add("Armor bonus: +" + Variables.bonusDarkAr + "%");
                    if (Variables.bonusDarkSpd > 0)
                        lstAbility2.Items.Add("Speed bonus: +" + Variables.bonusDarkSpd + "%");
                    if (Variables.bonusDarkCDam > 0)
                        lstAbility2.Items.Add("Critical Damage bonus: +" + Variables.bonusDarkCDam + "%");
                    if (Variables.bonusDarkRed > 0)
                        lstAbility2.Items.Add("Damage Reduction bonus: +" + Variables.bonusDarkRed + "%");
                }
            }
            else
            {
                MessageBox.Show("Please select at least one team member");
            }
        }

        private void btnClearTeam_Click(object sender, EventArgs e)
        {
            ClearTeam();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearTeam();
            ResetAbilityCalc();
        }

        private void PopulateSub(out ListViewItem I1, out ListViewItem I2, out ListViewItem I3, out ListViewItem I4, out ListViewItem I5, out ListViewItem I6, out ListViewItem I7)
        {
            ListViewItem item1 = new ListViewItem("Faction");
            ListViewItem item2 = new ListViewItem("Type");
            ListViewItem item3 = new ListViewItem("Power");
            ListViewItem item4 = new ListViewItem("HP");
            ListViewItem item5 = new ListViewItem("Attack");
            ListViewItem item6 = new ListViewItem("Armor");
            ListViewItem item7 = new ListViewItem("Speed");
            int id = int.Parse(lstTMchooser.SelectedValue.ToString());
            item1.SubItems.Add(creature_DatabaseDataSet.Tables[0].Rows[id - 1].ItemArray[2].ToString());
            item2.SubItems.Add(creature_DatabaseDataSet.Tables[0].Rows[id - 1].ItemArray[3].ToString());
            item3.SubItems.Add(creature_DatabaseDataSet.Tables[0].Rows[id - 1].ItemArray[4].ToString());
            item4.SubItems.Add(creature_DatabaseDataSet.Tables[0].Rows[id - 1].ItemArray[5].ToString());
            item5.SubItems.Add(creature_DatabaseDataSet.Tables[0].Rows[id - 1].ItemArray[6].ToString());
            item6.SubItems.Add(creature_DatabaseDataSet.Tables[0].Rows[id - 1].ItemArray[7].ToString());
            item7.SubItems.Add(creature_DatabaseDataSet.Tables[0].Rows[id - 1].ItemArray[8].ToString());
            I1 = item1;
            I2 = item2;
            I3 = item3;
            I4 = item4;
            I5 = item5;
            I6 = item6;
            I7 = item7;
        }

        private void AbilityFinder(out string AF1, out int AF2, out int AF3, out int AF4)
        {
            int id = int.Parse(lstTMchooser.SelectedValue.ToString());
            AF1 = "";
            AF2 = 0;
            AF3 = 0;
            AF4 = 0;
            string af1 = creature_DatabaseDataSet.Tables[0].Rows[id - 1].ItemArray[2].ToString();
            string af2 = creature_DatabaseDataSet.Tables[0].Rows[id - 1].ItemArray[10].ToString();
            string af3 = creature_DatabaseDataSet.Tables[0].Rows[id - 1].ItemArray[11].ToString();
            string af4 = creature_DatabaseDataSet.Tables[0].Rows[id - 1].ItemArray[12].ToString();
            switch (af1)
            {
                case "Evil":
                    AF1 = "Evil";
                    break;

                case "Bastion":
                    AF1 = "Bastion";
                    break;

                case "Chaos":
                    AF1 = "Chaos";
                    break;

                case "Forest":
                    AF1 = "Forest";
                    break;

                case "Dark":
                    AF1 = "Dark";
                    break;

                case "Light":
                    AF1 = "Light";
                    break;
            }
            switch (af2)
            {
                case "Evil Life":
                    AF2 = 10;
                    break;

                case "Evil Attack":
                    AF2 = 11;
                    break;

                case "Evil Armor":
                    AF2 = 12;
                    break;

                case "Evil Speed":
                    AF2 = 13;
                    break;

                case "Evil Crit. Dam":
                    AF2 = 14;
                    break;

                case "Evil Reduce":
                    AF2 = 15;
                    break;

                case "Bas. Life":
                    AF2 = 20;
                    break;

                case "Bas. Attack":
                    AF2 = 21;
                    break;

                case "Bas. Armor":
                    AF2 = 22;
                    break;

                case "Bas. Speed":
                    AF2 = 23;
                    break;

                case "Bas. Crit. Dam":
                    AF2 = 24;
                    break;

                case "Bas. Reduce":
                    AF2 = 25;
                    break;

                case "Chaos Life":
                    AF2 = 30;
                    break;

                case "Chaos Attack":
                    AF2 = 31;
                    break;

                case "Chaos Armor":
                    AF2 = 32;
                    break;

                case "Chaos Speed":
                    AF2 = 33;
                    break;

                case "Chaos Crit. Dam":
                    AF2 = 34;
                    break;

                case "Chaos Reduce":
                    AF2 = 35;
                    break;

                case "Forest Life":
                    AF2 = 40;
                    break;

                case "Forest Attack":
                    AF2 = 41;
                    break;

                case "Forest Armor":
                    AF2 = 42;
                    break;

                case "Forest Speed":
                    AF2 = 43;
                    break;

                case "Forest Crit. Dam":
                    AF2 = 44;
                    break;

                case "Forest Reduce":
                    AF2 = 45;
                    break;

                case "Complete Life":
                    AF2 = 50;
                    break;

                case "Complete Attack":
                    AF2 = 51;
                    break;

                case "Complete Armor":
                    AF2 = 52;
                    break;

                case "Complete Speed":
                    AF2 = 53;
                    break;

                case "Complete Crit. Dam":
                    AF2 = 54;
                    break;

                case "Complete Reduce":
                    AF2 = 55;
                    break;
            }
            switch (af3)
            {
                case "Evil Life":
                    AF3 = 10;
                    break;

                case "Evil Attack":
                    AF3 = 11;
                    break;

                case "Evil Armor":
                    AF3 = 12;
                    break;

                case "Evil Speed":
                    AF3 = 13;
                    break;

                case "Evil Crit. Dam":
                    AF3 = 14;
                    break;

                case "Evil Reduce":
                    AF3 = 15;
                    break;

                case "Bas. Life":
                    AF3 = 20;
                    break;

                case "Bas. Attack":
                    AF3 = 21;
                    break;

                case "Bas. Armor":
                    AF3 = 22;
                    break;

                case "Bas. Speed":
                    AF3 = 23;
                    break;

                case "Bas. Crit. Dam":
                    AF3 = 24;
                    break;

                case "Bas. Reduce":
                    AF3 = 25;
                    break;

                case "Chaos Life":
                    AF3 = 30;
                    break;

                case "Chaos Attack":
                    AF3 = 31;
                    break;

                case "Chaos Armor":
                    AF3 = 32;
                    break;

                case "Chaos Speed":
                    AF3 = 33;
                    break;

                case "Chaos Crit. Dam":
                    AF3 = 34;
                    break;

                case "Chaos Reduce":
                    AF3 = 35;
                    break;

                case "Forest Life":
                    AF3 = 40;
                    break;

                case "Forest Attack":
                    AF3 = 41;
                    break;

                case "Forest Armor":
                    AF3 = 42;
                    break;

                case "Forest Speed":
                    AF3 = 43;
                    break;

                case "Forest Crit. Dam":
                    AF3 = 44;
                    break;

                case "Forest Reduce":
                    AF3 = 45;
                    break;

                case "Complete Life":
                    AF3 = 50;
                    break;

                case "Complete Attack":
                    AF3 = 51;
                    break;

                case "Complete Armor":
                    AF3 = 52;
                    break;

                case "Complete Speed":
                    AF3 = 53;
                    break;

                case "Complete Crit. Dam":
                    AF3 = 54;
                    break;

                case "Complete Reduce":
                    AF3 = 55;
                    break;
            }
            switch (af4)
            {
                case "Evil Life":
                    AF4 = 10;
                    break;

                case "Evil Attack":
                    AF4 = 11;
                    break;

                case "Evil Armor":
                    AF4 = 12;
                    break;

                case "Evil Speed":
                    AF4 = 13;
                    break;

                case "Evil Crit. Dam":
                    AF4 = 14;
                    break;

                case "Evil Reduce":
                    AF4 = 15;
                    break;

                case "Bas. Life":
                    AF4 = 20;
                    break;

                case "Bas. Attack":
                    AF4 = 21;
                    break;

                case "Bas. Armor":
                    AF4 = 22;
                    break;

                case "Bas. Speed":
                    AF4 = 23;
                    break;

                case "Bas. Crit. Dam":
                    AF4 = 24;
                    break;

                case "Bas. Reduce":
                    AF4 = 25;
                    break;

                case "Chaos Life":
                    AF4 = 30;
                    break;

                case "Chaos Attack":
                    AF4 = 31;
                    break;

                case "Chaos Armor":
                    AF4 = 32;
                    break;

                case "Chaos Speed":
                    AF4 = 33;
                    break;

                case "Chaos Crit. Dam":
                    AF4 = 34;
                    break;

                case "Chaos Reduce":
                    AF4 = 35;
                    break;

                case "Forest Life":
                    AF4 = 40;
                    break;

                case "Forest Attack":
                    AF4 = 41;
                    break;

                case "Forest Armor":
                    AF4 = 42;
                    break;

                case "Forest Speed":
                    AF4 = 43;
                    break;

                case "Forest Crit. Dam":
                    AF4 = 44;
                    break;

                case "Forest Reduce":
                    AF4 = 45;
                    break;

                case "Complete Life":
                    AF4 = 50;
                    break;

                case "Complete Attack":
                    AF4 = 51;
                    break;

                case "Complete Armor":
                    AF4 = 52;
                    break;

                case "Complete Speed":
                    AF4 = 53;
                    break;

                case "Complete Crit. Dam":
                    AF4 = 54;
                    break;

                case "Complete Reduce":
                    AF4 = 55;
                    break;
            }   
        }

        public void GetAbilityBonus(double tempTMB)
        {
            double input = tempTMB;
            if (input >= 10 && input <= 19) //Evil
            {
                if (input == 10) //Life
                    Variables.bonusEvilLife += 15;
                else if (input == 11) //Attack
                    Variables.bonusEvilAtk += 15;
                else if (input == 12) //Armor
                    Variables.bonusEvilAr += 15;
                else if (input == 13) //Speed
                    Variables.bonusEvilSpd += 15;
                else if (input == 14) //Crit Damage
                    Variables.bonusEvilCDam += 30;
                else if (input == 15) //Damage Reduction
                    Variables.bonusEvilRed += 10;
            }
            else if (input >= 20 && input <= 29) //Bastion
            {
                if (input == 20) //Life
                    Variables.bonusBasLife += 15;
                else if (input == 21) //Attack
                    Variables.bonusBasAtk += 15;
                else if (input == 22) //Armor
                    Variables.bonusBasAr += 15;
                else if (input == 23) //Speed
                    Variables.bonusBasSpd += 15;
                else if (input == 24) //Crit Damage
                    Variables.bonusBasCDam += 30;
                else if (input == 25) //Damage Reduction
                    Variables.bonusBasRed += 10;
            }
            else if (input >= 30 && input <= 39) //Chaos
            {
                if (input == 30) //Life
                    Variables.bonusChaLife += 15;
                else if (input == 31) //Attack
                    Variables.bonusChaAtk += 15;
                else if (input == 32) //Armor
                    Variables.bonusChaAr += 15;
                else if (input == 33) //Speed
                    Variables.bonusChaSpd += 15;
                else if (input == 34) //Crit Damage
                    Variables.bonusChaCDam += 30;
                else if (input == 35) //Damage Reduction
                    Variables.bonusChaRed += 10;
            }
            if (input >= 40 && input <= 49) //Forest
            {
                if (input == 40) //Life
                    Variables.bonusForestLife += 15;
                else if (input == 41) //Attack
                    Variables.bonusForestAtk += 15;
                else if (input == 42) //Armor
                    Variables.bonusForestAr += 15;
                else if (input == 43) //Speed
                    Variables.bonusForestSpd += 15;
                else if (input == 44) //Crit Damage
                    Variables.bonusForestCDam += 30;
                else if (input == 45) //Damage Reduction
                    Variables.bonusForestRed += 10;
            }
            else if (input >= 50 && input <= 59) //Complete
            {
                if (input == 50) //Life
                {
                    Variables.bonusEvilLife += 10;
                    Variables.bonusBasLife += 10;
                    Variables.bonusChaLife += 10;
                    Variables.bonusForestLife += 10;
                    Variables.bonusLightLife += 10;
                    Variables.bonusDarkLife += 10;
                }
                else if (input == 51) //Attack
                {
                    Variables.bonusEvilAtk += 10;
                    Variables.bonusBasAtk += 10;
                    Variables.bonusChaAtk += 10;
                    Variables.bonusForestAtk += 10;
                    Variables.bonusLightAtk += 10;
                    Variables.bonusDarkAtk += 10;
                }
                else if (input == 52) //Armor
                {
                    Variables.bonusEvilAr += 10;
                    Variables.bonusBasAr += 10;
                    Variables.bonusChaAr += 10;
                    Variables.bonusForestAr += 10;
                    Variables.bonusLightAr += 10;
                    Variables.bonusDarkAr += 10;
                }
                else if (input == 53) //Speed
                {
                    Variables.bonusEvilSpd += 25;
                    Variables.bonusBasSpd += 25;
                    Variables.bonusChaSpd += 25;
                    Variables.bonusForestSpd += 25;
                    Variables.bonusLightSpd += 25;
                    Variables.bonusDarkSpd += 25;
                }
                else if (input == 54) //Crit Damage
                {
                    Variables.bonusEvilCDam += 30;
                    Variables.bonusBasCDam += 30;
                    Variables.bonusChaCDam += 30;
                    Variables.bonusForestCDam += 30;
                    Variables.bonusLightCDam += 30;
                    Variables.bonusDarkCDam += 30;
                }
                else if (input == 55) //Damage Reduction
                {
                    Variables.bonusEvilRed += 10;
                    Variables.bonusBasRed += 10;
                    Variables.bonusChaRed += 10;
                    Variables.bonusForestRed += 10;
                    Variables.bonusLightRed += 10;
                    Variables.bonusDarkRed += 10;
                }
            }
        }

        private void ClearTeam()
        {
            powTMone = 0;
            powTMtwo = 0;
            powTMthree = 0;
            powTMfour = 0;
            powTMfive = 0;
            powTMsix = 0;
            powTMtotal = 0;
            powApproxTotal = 0;
            lsvTMone.Items.Clear();
            lsvTMtwo.Items.Clear();
            lsvTMthree.Items.Clear();
            lsvTMfour.Items.Clear();
            lsvTMfive.Items.Clear();
            lsvTMsix.Items.Clear();
            txtPowCnt.Text = "0";
            txtApproxPower.Text = "0";
            Variables.TMoneFaction = "";
            Variables.TMoneAFind1 = 0;
            Variables.TMoneAFind2 = 0;
            Variables.TMoneAFind3 = 0;
            Variables.TMtwoFaction = "";
            Variables.TMtwoAFind1 = 0;
            Variables.TMtwoAFind2 = 0;
            Variables.TMtwoAFind3 = 0;
            Variables.TMthreeFaction = "";
            Variables.TMthreeAFind1 = 0;
            Variables.TMthreeAFind2 = 0;
            Variables.TMthreeAFind3 = 0;
            Variables.TMfourFaction = "";
            Variables.TMfourAFind1 = 0;
            Variables.TMfourAFind2 = 0;
            Variables.TMfourAFind3 = 0;
            Variables.TMfiveFaction = "";
            Variables.TMfiveAFind1 = 0;
            Variables.TMfiveAFind2 = 0;
            Variables.TMfiveAFind3 = 0;
            Variables.TMsixFaction = "";
            Variables.TMsixAFind1 = 0;
            Variables.TMsixAFind2 = 0;
            Variables.TMsixAFind3 = 0;

        }

        private void ResetAbilityCalc()
        {
            lstAbility.Items.Clear();
            lstAbility2.Items.Clear();
            Variables.bonusEvilLife = 0; Variables.bonusEvilAtk = 0; Variables.bonusEvilAr = 0; Variables.bonusEvilSpd = 0; Variables.bonusEvilCDam = 0; Variables.bonusEvilRed = 0;
            Variables.bonusBasLife = 0; Variables.bonusBasAtk = 0; Variables.bonusBasAr = 0; Variables.bonusBasSpd = 0; Variables.bonusBasCDam = 0; Variables.bonusBasRed = 0;
            Variables.bonusChaLife = 0; Variables.bonusChaAtk = 0; Variables.bonusChaAr = 0; Variables.bonusChaSpd = 0; Variables.bonusChaCDam = 0; Variables.bonusChaRed = 0;
            Variables.bonusForestLife = 0; Variables.bonusForestAtk = 0; Variables.bonusForestAr = 0; Variables.bonusForestSpd = 0; Variables.bonusForestCDam = 0; Variables.bonusForestRed = 0;
            Variables.bonusLightLife = 0; Variables.bonusLightAtk = 0; Variables.bonusLightAr = 0; Variables.bonusLightSpd = 0; Variables.bonusLightCDam = 0; Variables.bonusLightRed = 0;
            Variables.bonusDarkLife = 0; Variables.bonusDarkAtk = 0; Variables.bonusDarkAr = 0; Variables.bonusDarkSpd = 0; Variables.bonusDarkCDam = 0; Variables.bonusDarkRed = 0;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
