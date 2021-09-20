using Dice_Roller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomCardSelector
{
    public partial class Form1 : Form
    {
        //public static Form1 instance = new Form1();

        // used for real random number function
        internal RNGCryptoServiceProvider Rand = new RNGCryptoServiceProvider();

        // CSV file loader / dataset variables
        static List<CardSystemManager> cardTypeList1;// = new List<CardSystemManager>();
        static List<CardSystemManager> cardTypeList2;// = new List<CardSystemManager>();

        

        public Form1()
        {
            


            InitializeComponent();


            //if (instance != null)
            //{
            //    return;
            //}

            //instance = this;


            // setup app functions
            SetDefaultValues();



            randomCardModeRadioButton.Select();


            //string csvFileLocation = ".\";
            string csvFileName = "CardData.csv";




            CardSystemManager cardSystem = new CardSystemManager();

            cardTypeList1 = new List<CardSystemManager>();
            cardTypeList2 = new List<CardSystemManager>();

            bool didCSVfileLoad = cardSystem.CSVfileLoader(ref cardTypeList1, ref cardTypeList2, /* csvFileLocation,*/ csvFileName, ref cardSystem.customCardType1, ref cardSystem.customCardType2);

            if (didCSVfileLoad == false)
            {
                // disable the random button
                // leave msg for use to update file and then run the app again.

                ListOfCardType1ComboBox.SelectedItem = 0;
                ListOfCardType1ComboBox.Enabled = false;
                
                ListOfCardType2ComboBox.SelectedItem = 0;
                ListOfCardType1ComboBox.Enabled = false;

                CardNameLabel.Text = "Update File, then Restart APP";
                cardDescriptionLabel.Text = "a File Carddata.csv was created as it was missing. so read the file and imput the data required then start the application again.";

                CardTypeToRandomComboBox.SelectedItem = 0;
                CardTypeToRandomComboBox.Enabled = false;

                GetRandomCardFromListButton.Enabled = false;
            }
            else
            {
                int index = 0;
                foreach (CardSystemManager item in cardTypeList1)
                {
                    // add card to list for viewing
                    //cardTypeList1.Add(item);

                    ListOfCardType1ComboBox.Items.Add(item.CardName);

                    index++;
                }

                index = 0;

                foreach (CardSystemManager item in cardTypeList2)
                {
                    // add card to list for viewing
                    //cardTypeList2.Add(item);

                    ListOfCardType2ComboBox.Items.Add(item.CardName);

                    index++;
                }

                if(cardSystem.customCardType1 != "")
                {
                    CardTypeToRandomComboBox.Items.Add(cardSystem.customCardType1);
                    CardTypeToRandomComboBox.Items.Add(cardSystem.customCardType2);
                }
                else
                {
                    CardTypeToRandomComboBox.Items.Add("Card Type 1");
                    CardTypeToRandomComboBox.Items.Add("Card Type 2");
                }
                
                CardTypeToRandomComboBox.SelectedIndex = 0; // selects first element in array
                
                
                //ListOfCardType1ComboBox.SelectedIndex = 0;
                ListOfCardType1ComboBox.Enabled = true;
                //ListOfCardType2ComboBox.SelectedIndex = 0;
                ListOfCardType2ComboBox.Enabled = true;

                randomCardModeRadioButton.Select();

                ListOfCardType1ComboBox.Enabled = false;
                ListOfCardType2ComboBox.Enabled = false;

            }

            

        }

        private void SetDefaultValues()
        {
            ListOfCardType1ComboBox.SelectedItem = 0;
            ListOfCardType2ComboBox.SelectedItem = 0;

            CardNameLabel.Text = "";
            cardDescriptionLabel.Text = "";

            CardTypeToRandomComboBox.SelectedItem = 0;

            GetRandomCardFromListButton.Enabled = false;

            

            ListOfCardType1ComboBox.Enabled = false;
            ListOfCardType2ComboBox.Enabled = false;
        }

        private void randomCardModeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetDefaultValues();

            ListOfCardType1ComboBox.Enabled = false;
            ListOfCardType2ComboBox.Enabled = false;

            GetRandomCardFromListButton.Enabled = true;
            CardTypeToRandomComboBox.Enabled = true;
        }

        private void viewCardsType1ModeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetDefaultValues();

            ListOfCardType1ComboBox.Enabled = true;
            ListOfCardType2ComboBox.Enabled = false;

            GetRandomCardFromListButton.Enabled = false;
            CardTypeToRandomComboBox.Enabled = false;

            
        }

        private void viewCardsType2ModeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ListOfCardType1ComboBox.Enabled = false;
            ListOfCardType2ComboBox.Enabled = true;

            GetRandomCardFromListButton.Enabled = false;
            CardTypeToRandomComboBox.Enabled = false;
        }

        private void CardTypeToRandomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if index 0
            if (CardTypeToRandomComboBox.SelectedIndex ==  0 && randomCardModeRadioButton.Enabled == true)
            {
                GetRandomCardFromListButton.Enabled = true;

            }
            else if (CardTypeToRandomComboBox.SelectedIndex == 1 && randomCardModeRadioButton.Enabled == true)
            {
                GetRandomCardFromListButton.Enabled = true;
            }
            else
            {
                GetRandomCardFromListButton.Enabled = false;
            }
            
        }


        internal int RandomInteger(int min, int max)
        {
            uint scale = uint.MaxValue;

            while (scale == uint.MaxValue)
            {
                byte[] four_bytes = new byte[4];
                Rand.GetBytes(four_bytes);

                scale = BitConverter.ToUInt32(four_bytes, 0);
            }

            return (int)(min + (max - min) * (scale / (double)uint.MaxValue));
        }



        private void GetRandomCardFromListButton_Click(object sender, EventArgs e)
        {
            // get random number depending on list and # of elements in list.
            int maxCardID = CardTypeToRandomComboBox.SelectedIndex;

            if(maxCardID == 0)
            {
               //MessageBox.Show("deck type: " + CardTypeToRandomComboBox.Items.Count + ", ncardType1List count: " + ListOfCardType1ComboBox.Items.Count + ", maxCardID = " + maxCardID);
                maxCardID = ListOfCardType1ComboBox.Items.Count;



                int RandomCardIDNumber = RandomInteger(0, maxCardID);

                CardNameLabel.Text = cardTypeList1[RandomCardIDNumber].CardName;

                //StringBuilder sb = new StringBuilder();
                //sb.AppendLine(cardTypeList1[RandomCardIDNumber].CardDescription);
                //cardDescriptionLabel.Text = sb.ToString().Replace("<br />", Environment.NewLine);

                cardDescriptionLabel.Text = InputFormatting_StringBUilder(cardTypeList1[RandomCardIDNumber].CardDescription, "<br />");
                cardDescriptionLabel.Text = InputFormatting_StringBUilder(cardDescriptionLabel.Text, "<?>");

                //cardDescriptionLabel.Text = cardTypeList1[RandomCardIDNumber].CardDescription;
            }
            else // if(maxCardID == 1)
            {
                //MessageBox.Show("deck type: " + CardTypeToRandomComboBox.Items.Count + ", ncardType1List count: " + ListOfCardType1ComboBox.Items.Count + ", maxCardID = " + maxCardID);

                maxCardID = ListOfCardType2ComboBox.Items.Count;

                int RandomCardIDNumber = RandomInteger(0, maxCardID);

                CardNameLabel.Text = cardTypeList2[RandomCardIDNumber].CardName;

                //StringBuilder sb = new StringBuilder();
                //sb.AppendLine(cardTypeList2[RandomCardIDNumber].CardDescription);
                //cardDescriptionLabel.Text = sb.ToString().Replace("<br />", Environment.NewLine);

                cardDescriptionLabel.Text = InputFormatting_StringBUilder(cardTypeList2[RandomCardIDNumber].CardDescription, "<br />");

               // MessageBox.Show("card desc: " + cardDescriptionLabel.Text);

                cardDescriptionLabel.Text = InputFormatting_StringBUilder(cardDescriptionLabel.Text, "<?>");

                //cardDescriptionLabel.Text = cardTypeList2[RandomCardIDNumber].CardDescription;

            }


            

            // update the visuals on screen with the item found by ID and the random number.
            //MessageBox.Show("rand ID: " + RandomCardIDNumber.ToString());

            // update data for list boxes
            
        }

        internal string InputFormatting_StringBUilder(string currentText, string specialCharacterToChange)
        {
            StringBuilder sb = new StringBuilder();
            

            switch (specialCharacterToChange)
            {
                case "<br />":
                    {
                       // MessageBox.Show("<br /> testing for: " + specialCharacterToChange);

                        sb.AppendLine(currentText);
                        
                        return sb.ToString().Replace("<br />", Environment.NewLine);
                    }
                case "<?>":
                    {
                       // MessageBox.Show("<|>: testing for: " + specialCharacterToChange);

                        sb.AppendLine(currentText);
                        
                        return sb.ToString().Replace("<?>", ",");
                    }

                default:
                    {
                        MessageBox.Show("InputFormatting of string: " + currentText + ", using special character: " + specialCharacterToChange + ". Has run into an error");

                        return currentText;
                    }
            }


        }


        internal void SetCustomCardNames(string customCardName1, string customCardName2)
        {
            ListOfCardType1Label.Text = customCardName1;
            ListOfCardType2Label.Text = customCardName2;
        }

        private void ListOfCardType1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(ListOfCardType1ComboBox.Enabled)

            CardNameLabel.Text = "";
            cardDescriptionLabel.Text = "";

            UpdateDisplayedCardInfo(ListOfCardType1ComboBox.SelectedIndex, true);

           // MessageBox.Show("index: " + ListOfCardType1ComboBox.SelectedIndex);
        }

        private void ListOfCardType2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if(ListOfCardType2ComboBox.Enabled)

            CardNameLabel.Text = "";
            cardDescriptionLabel.Text = "";

            UpdateDisplayedCardInfo(ListOfCardType2ComboBox.SelectedIndex, false);
        }


        internal void UpdateDisplayedCardInfo(int index, bool isCardType1)
        {

            if(isCardType1)
            {
                StringBuilder sb = new StringBuilder();

                if (ListOfCardType1ComboBox.Enabled && CardNameLabel.Text.Length <= 0)
                {
                    CardNameLabel.Text = cardTypeList1[index].CardName;

                    
                    //sb.AppendLine(cardTypeList1[index].CardDescription);
                    //cardDescriptionLabel.Text = sb.ToString().Replace("<br />", Environment.NewLine);

                    cardDescriptionLabel.Text = InputFormatting_StringBUilder(cardTypeList1[index].CardDescription, "<br />");
                    cardDescriptionLabel.Text = InputFormatting_StringBUilder(cardDescriptionLabel.Text, "<?>");



                    //cardDescriptionLabel.Text = cardTypeList1[index].CardDescription;

                }

                
            }
            else
            {
                CardNameLabel.Text = cardTypeList2[index].CardName;

                //StringBuilder sb = new StringBuilder();
                //sb.AppendLine(cardTypeList2[index].CardDescription);
                //cardDescriptionLabel.Text = sb.ToString().Replace("<br />", Environment.NewLine);

                cardDescriptionLabel.Text = InputFormatting_StringBUilder(cardTypeList2[index].CardDescription, "<br />");
                cardDescriptionLabel.Text = InputFormatting_StringBUilder(cardDescriptionLabel.Text, "<?>");

                //cardDescriptionLabel.Text = cardTypeList2[index].CardDescription;
            }

            CardNameLabel.Refresh();
            cardDescriptionLabel.Refresh();
        }
    }
}
