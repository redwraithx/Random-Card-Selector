using RandomCardSelector;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Roller
{
    class CardSystemManager
    {
        /*
         * Saved File will have 2 peices of data per line.
         * -----------------------------------------------
         * 1st item is the cards name
         * 2nd item is the cards description.
         * 
         * an ID will be auto assigned to the new data at load time
         * 
         */

        

        public string ID { get; set; }
        public string CardName { get; set; }
        public string CardDescription { get; set; }
        public string CardType { get; set; }

        public string customCardType1;
        public string customCardType2;


        public CardSystemManager()
        {
            customCardType1 = "";
            customCardType2 = "";
        }

        public bool CSVfileLoader(ref List<CardSystemManager> cardDataSet1, ref List<CardSystemManager> cardDataSet2, string cardFileName, ref string customCardType1, ref string customCardType2)
        {
            
            customCardType1 = "Card Type 1";
            customCardType2 = "Card Type 2";

            CardSystemManager dataSetItem;
            int idCounter = 0;

            //string cardFile = cardFileLocation + cardFileName;
            string cardFile = Path.Combine(Environment.CurrentDirectory, cardFileName);


            // check for cardfile, else create file with information on how to load the data.
            if (!File.Exists(cardFile))
            {
                try
                {
                    using (File.Create(cardFile)) ; // if file does exsist it will be created.

                    using (StreamWriter writeFile = new StreamWriter(cardFile))
                    {
                        writeFile.WriteLine("# Format cards for this file: CardName, CardsDescription, CardType either (cardType1 or cardType2)");
                        writeFile.WriteLine("# Example of data in file: Fire Ball,Burns all things that get in the way,cardType1");
                        writeFile.WriteLine("# Format for displayed card type names use % but can only have 2 at any given time");
                        writeFile.WriteLine("# Warning, the custom card types are only for display. they dont replace cardType1 or cardType2");
                        writeFile.WriteLine("# Example of custom card type names: %EventCards,ActionCards");
                        writeFile.WriteLine("# MAKE SURE YOU HAVE NO EMPTY LINES or put # on them.");
                        writeFile.WriteLine("# Adding <?> to a line will be converted to a , as csv files seperate data with them and can't be used.");
                        writeFile.WriteLine("#---------------------------------------------------------------------------------------------------------------");
                        
                        writeFile.Close();
                    }

                    // created new file, exited the loader and disable until next run which may have information.
                    return false;

                }
                catch (Exception)
                {
                    MessageBox.Show("Error with Creating card File. " + cardFile);

                    throw;
                }


            }




            using (StreamReader readFile = new StreamReader(cardFile))
            {

                while (!readFile.EndOfStream)
                {
                    

                    string[] token = readFile.ReadLine().Split(',');

                    //MessageBox.Show(token[0]);

                    if (token[0].Contains('#')) // Will not read in any data for lines with # as this is denoted as comment or information lines
                    {
                        continue;
                    }
                    else if (token[0].Contains('%'))
                    {
                        // set the type of cards to use.
                        // value 1 = cardTYpe1, value 2 = cardType2

                        // remove the special character % from the first token before assigning the variables
                        token[0] = token[0].TrimStart('%');

                        // assign the variables
                        customCardType1 = token[0];
                        customCardType2 = token[1];

                        //Form1.instance.SetCustomCardNames(customCardType1, customCardType2);

                        continue;
                    }

                    // add data to the newDataset
                    dataSetItem = new CardSystemManager();

                    dataSetItem.ID = idCounter.ToString();
                    dataSetItem.CardName = token[0];
                    dataSetItem.CardDescription = token[1];
                    dataSetItem.CardType = token[2];

                    
                    idCounter++;

                    if (dataSetItem.CardType == "cardType1")
                    {
                        cardDataSet1.Add(dataSetItem);
                    }
                    else if (dataSetItem.CardType == "cardType2")
                    {
                        cardDataSet2.Add(dataSetItem);
                    }
                    else
                    {
                        MessageBox.Show("Error with card type name, Check your data file (look for issues with the comma's) and update this. CARDNAME: " + dataSetItem.CardName + ", CARDDESCRIPTION: " + dataSetItem.CardDescription + ", CARDTYPE: " + dataSetItem.CardType);
                        Application.Exit();
                    }

                }

                readFile.Close();
            }

        //MessageBox.Show("dataSet0: " + cardDataSet0.Count.ToString() + ", " + cardDataSet1.Count.ToString());
            
                      

            // may need to sort and seperate the cards by the cardtype variable and save the items to the proper dataSet
            if (cardDataSet1.Count > 0 && cardDataSet1.Count > 0)
                return true;
            else
                return false;
        }







    }
}
