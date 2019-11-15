using System;
using System.Collections.Generic;
using System.Text;

namespace VCDrapery.Server.Business
{
    public static class QuoteCalculations
    {
        public static QuoteModel ToQuoteModel(this List<QuoteLineItemModel> items)
        {
            QuoteModel quote = new QuoteModel() { LineItems = new List<QuoteLineItemModel>() };
            
            try
            {
                foreach (QuoteLineItemModel item in items)
                {
                    decimal fabricBasePrice = 0;
                    switch (item.FabricType)
                    {
                        case "Snowbird":
                            fabricBasePrice = 28;
                            item.FabricFabFmg = 54;
                            break;
                        case "Handcart":
                            fabricBasePrice = 28;
                            item.FabricFabFmg = 72;
                            break;
                        case "Layton":
                            fabricBasePrice = 28;
                            item.FabricFabFmg = 54;
                            break;
                        case "NewFifth":
                            fabricBasePrice = 28;
                            item.FabricFabFmg = 54;
                            break;
                        case "Petals":
                            fabricBasePrice = 23;
                            item.FabricFabFmg = 72;
                            break;
                        case "Voil":
                            fabricBasePrice = 10;
                            item.FabricFabFmg = 118;
                            break;
                        case "Baptiste":
                            fabricBasePrice = 10;
                            item.FabricFabFmg = 118;
                            break;
                        case "BO":
                            fabricBasePrice = 12;
                            item.FabricFabFmg = 54;
                            break;
                        case "Lining":
                            fabricBasePrice = 12;
                            item.FabricFabFmg = 12;
                            break;
                        case "Prestige":
                            fabricBasePrice = 37;
                            item.FabricFabFmg = 54;
                            break;
                        case "HandcartWhite":
                            fabricBasePrice = 28;
                            item.FabricFabFmg = 72;
                            break;
                        case "ZanzibarWhite":
                            fabricBasePrice = 37;
                            item.FabricFabFmg = 54;
                            break;
                    }

                    switch (item.RodType)
                    {
                        case "Thirty-FourtyEight":
                            item.RodPrice = 25;
                            break;
                        case "ThirtyEight-SixtySix":
                            item.RodPrice = 27;
                            break;
                        case "FourtyEight-EightySix":
                            item.RodPrice = 31;
                            break;
                        case "SixtySix-OneTwenty":
                            item.RodPrice = 45;
                            break;
                        case "EightySix-OneFifty":
                            item.RodPrice = 50;
                            break;
                        case "One-OneEighty":
                            item.RodPrice = 55;
                            break;
                        case "OneTwenty-TwoTwoFour":
                            item.RodPrice = 60;
                            break;
                        case "OneSixty-ThreeHundred":
                            item.RodPrice = 110;
                            break;
                        case "RTB":
                            item.RodPrice = 15;
                            break;
                        case "Tension":
                            item.RodPrice = 20;
                            break;
                    }

                    item.Widths = (((item.RodSize * item.FabricFullness) + (item.Return * 2)) / item.FabricFabFmg); 
                    item.Yards = Math.Ceiling(((item.FabricLength + 20) * item.Widths) / 36);
                    item.WidthsLab = Math.Ceiling((item.RodSize / 2) / 19) * 2;
                    item.FabricPrice = fabricBasePrice * item.Yards;

                    item.LaborPrice = item.WidthsLab * 30;

                    decimal taxPercent = .09M;
                    item.PriceBeforeTax = item.RodPrice + item.LaborPrice + item.FabricPrice;
                    item.Tax = item.PriceBeforeTax * taxPercent;
                    item.TotalPrice = item.PriceBeforeTax + item.Tax;
                    

                    quote.LineItems.Add(item);

                    quote.QuotePrice += item.TotalPrice;
                }
            }
            catch(Exception cause)
            {
                Console.WriteLine(cause.Message);
            }
            return quote;
        }
    }
}
