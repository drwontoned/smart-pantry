using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm___SmartPantry
{
    public class Pantry
    {
        // list of products and sorting type;
        private List<Product> pantryList;
        private string sortType = string.Empty;
        private bool ascending = true;


        public List<Product> PantryList { get => this.pantryList; }

        // constructor that initializes new pantry list and sets sort type to alphabetical
        public Pantry()
        {
            this.pantryList = new List<Product>();
            this.sortType = "Alphabetical";
        }

        // Method for adding a new product into the pantry
        public void addToPantry(Product p)
        {
            PantryList.Add(p);
            this.pantryList = SortList(this.pantryList);
        }

        // Method for removing a product from the pantry
        public void removeFromPantry(Product p)
        {
            this.pantryList.Remove(p);
            this.pantryList = SortList(this.pantryList);
        }

        // Method for removing multiple items by index
        public void removeMultipleByIndices(int[] indices)
        {
            foreach (int index in indices)
            {
                this.pantryList.RemoveAt(index);
            }

            this.pantryList = SortList(this.pantryList);
        }

        // Method for getting a product from the pantry based on an input name
        public Product getProductByName(string name)
        {
            for (int i = 0; i < this.pantryList.Count; i++)
            {
                // make case insensitive for search
                if (this.pantryList[i].Name.ToLower() == name.ToLower())
                {
                    return pantryList[i];
                }
            }

            // if nothing found return null
            return null;
        }

        // Method for getting a product from a pantry based on an index
        public Product getProductByIndex(int index)
        {
            // make sure it is a valid index
            if (index >= 0 && index < this.pantryList.Count)
            {
                return this.pantryList[index];
            }

            // if invalid index return null
            return null;
        }

        // Method for getting pantry size
        public int getPantrySize()
        {
            return this.pantryList.Count;
        }

        // Method that sorts based on current sort type
        public List<Product> SortList(List<Product> pantryList)
        {
            if (this.sortType == "Alphabetical")
            {
                return alphabetSort(pantryList);
            }
            else if (this.sortType == "Type")
            {
                return typeSort(pantryList);
            }
            else if (this.sortType == "Location")
            {
                return locationSort(pantryList);
            }
            else if (this.sortType == "Expiration")
            {
                return expirationSort(pantryList);
            }
            else
            {
                return stockSort(pantryList);
            }
        }

        // Method to make the pantry list descending from being previously ascending
        private List<Product> descending(List<Product> pantryList)
        {
            List<Product> newList = new List<Product>();
            for (int i = pantryList.Count - 1; i >= 0; i--)
            {
                newList.Add(pantryList[i]);
            }
            return newList;
        }

        // Method to sort pantry list by name (alphabetically)
        private List<Product> alphabetSort(List<Product> pantryList)
        {
            List<Product> newList = new List<Product>();

            // loop through inserted list
            for (int i = 0; i < pantryList.Count; i++)
            {
                // if first item then add to the new list
                if (i == 0)
                {
                    newList.Add(pantryList[i]);
                }

                // otherwise start comparing
                else
                {
                    int currentCount = newList.Count;

                    // loop through new list
                    for (int j = 0; j < currentCount; j++)
                    {
                        // if pantry list product has a name alphabetically 
                        // before the product name in new list then insert 
                        // at that index
                        if (pantryList[i].Name.CompareTo(newList[j].Name) <= 0)
                        {
                            newList.Insert(j, pantryList[i]);
                        }

                        // otherwise pantry lists name comes after
                        else
                        {
                            // if the name is after and loop is at end of new list 
                            // then just add it to the end of new list
                            if (j == newList.Count - 1)
                            {
                                newList.Add(pantryList[i]);
                            }
                        }
                    }
                }
            }

            // return a sorted ascending or descending list
            if (ascending)
            {
                return newList;
            }
            else
            {
                return descending(newList);
            }
        }

        // Method to sort pantry list by type
        private List<Product> typeSort(List<Product> pantryList)
        {
            List<Product> typeList = new List<Product>();
            List<Product> noTypeList = new List<Product>();

            // loop through inserted list
            for (int i = 0; i < pantryList.Count; i++)
            {
                // seperate noType and type
                if (pantryList[i].Type == string.Empty)
                {
                    noTypeList.Add(pantryList[i]);
                }
                else
                {
                    typeList.Add(pantryList[i]);
                }
            }

            List<Product> newList = new List<Product>();

            // loop through and sort typeList
            for (int i = 0; i < typeList.Count; i++)
            {
                // if first item then add to the new list
                if (i == 0)
                {
                    newList.Add(typeList[i]);
                }

                // otherwise start comparing
                else
                {
                    int currentCount = newList.Count;

                    // loop through new list
                    for (int j = 0; j < currentCount; j++)
                    {
                        // if pantry list product has a type alphabetically 
                        // before the product type in new list then insert 
                        // at that index
                        if (typeList[i].Type.CompareTo(newList[j].Type) <= 0)
                        {
                            newList.Insert(j, typeList[i]);
                        }

                        // otherwise pantry lists type comes after
                        else
                        {
                            // if the type is after and loop is at end of new list 
                            // then just add it to the end of new list
                            if (j == newList.Count - 1)
                            {
                                newList.Add(typeList[i]);
                            }
                        }
                    }
                }
            }

            // sort list of products with no type alphabetically
            noTypeList = alphabetSort(noTypeList);

            // add this sorted list to the end of the new list
            for (int i = 0; i < noTypeList.Count; i++)
            {
                newList.Add(noTypeList[i]);
            }

            // return a sorted ascending or descending list
            if (ascending)
            {
                return newList;
            }
            else
            {
                return descending(newList);
            }
        }

        // Method to sort pantry list by location
        private List<Product> locationSort(List<Product> pantryList)
        {
            List<Product> locationList = new List<Product>();
            List<Product> noLocationList = new List<Product>();

            // loop through inserted list
            for (int i = 0; i < pantryList.Count; i++)
            {
                // seperate nolocation and location
                if (pantryList[i].Location == string.Empty)
                {
                    noLocationList.Add(pantryList[i]);
                }
                else
                {
                    locationList.Add(pantryList[i]);
                }
            }

            List<Product> newList = new List<Product>();

            // loop through and sort locationList
            for (int i = 0; i < locationList.Count; i++)
            {
                // if first item then add to the new list
                if (i == 0)
                {
                    newList.Add(locationList[i]);
                }

                // otherwise start comparing
                else
                {
                    int currentCount = newList.Count;

                    // loop through new list
                    for (int j = 0; j < currentCount; j++)
                    {
                        // if pantry list product has a location alphabetically 
                        // before the product location in new list then insert 
                        // at that index
                        if (locationList[i].Location.CompareTo(newList[j].Location) <= 0)
                        {
                            newList.Insert(j, locationList[i]);
                        }

                        // otherwise pantry lists location comes after
                        else
                        {
                            // if the location is after and loop is at end of new list 
                            // then just add it to the end of new list
                            if (j == newList.Count - 1)
                            {
                                newList.Add(locationList[i]);
                            }
                        }
                    }
                }
            }

            // sort list of products with no location alphabetically
            noLocationList = alphabetSort(noLocationList);

            // add this sorted list to the end of the new list
            for (int i = 0; i < noLocationList.Count; i++)
            {
                newList.Add(noLocationList[i]);
            }

            // return a sorted ascending or descending list
            if (ascending)
            {
                return newList;
            }
            else
            {
                return descending(newList);
            }
        }

        // Method to sort by expiration date
        private List<Product> expirationSort(List<Product> pantryList)
        {
            List<Product> expirationList = new List<Product>();
            List<Product> noExpirationList = new List<Product>();

            // loop through inserted list
            for (int i = 0; i < pantryList.Count; i++)
            {
                // seperate noExpiration and expiration
                if (pantryList[i].ExpirationDates.Count < 1)
                {
                    noExpirationList.Add(pantryList[i]);
                }
                else
                {
                    expirationList.Add(pantryList[i]);
                }
            }

            List<Product> newList = new List<Product>();

            // loop through and sort expirationList
            for (int i = 0; i < expirationList.Count; i++)
            {
                // if first item then add to the new list
                if (i == 0)
                {
                    newList.Add(expirationList[i]);
                }

                // otherwise start comparing
                else
                {
                    int currentCount = newList.Count;

                    // loop through new list
                    for (int j = 0; j < currentCount; j++)
                    {
                        // if pantry list product has an expiration chronologically
                        // before the product expiration in new list then insert 
                        // at that index
                        if (expirationList[i].getOldestDate().CompareTo(newList[j].getOldestDate()) <= 0)
                        {
                            newList.Insert(j, expirationList[i]);
                        }

                        // otherwise pantry lists expiration comes after
                        else
                        {
                            // if the expiration is after and loop is at end of new list 
                            // then just add it to the end of new list
                            if (j == newList.Count - 1)
                            {
                                newList.Add(expirationList[i]);
                            }
                        }
                    }
                }
            }

            // sort list of products with no expiration alphabetically
            noExpirationList = alphabetSort(noExpirationList);

            // add this sorted list to the end of the new list
            for (int i = 0; i < noExpirationList.Count; i++)
            {
                newList.Add(noExpirationList[i]);
            }

            // return a sorted ascending or descending list
            if (ascending)
            {
                return newList;
            }
            else
            {
                return descending(newList);
            }
        }

        // Method to sort pantry list by stock
        private List<Product> stockSort(List<Product> pantryList)
        {
            List<Product> newList = new List<Product>();

            // loop through inserted list
            for (int i = 0; i < pantryList.Count; i++)
            {
                // if first item then add to the new list
                if (i == 0)
                {
                    newList.Add(pantryList[i]);
                }

                // otherwise start comparing
                else
                {
                    int currentCount = newList.Count;

                    // loop through new list
                    for (int j = 0; j < currentCount; j++)
                    {
                        // if pantry list product has less stock than the new list
                        // then insert at that index
                        if (pantryList[i].Stock.CompareTo(newList[j].Stock) <= 0)
                        {
                            newList.Insert(j, pantryList[i]);
                        }

                        // otherwise pantry lists stock is more
                        else
                        {
                            // if the stock is more and loop is at end of new list 
                            // then just add it to the end of new list
                            if (j == newList.Count - 1)
                            {
                                newList.Add(pantryList[i]);
                            }
                        }
                    }
                }
            }

            // return a sorted ascending or descending list
            if (ascending)
            {
                return newList;
            }
            else
            {
                return descending(newList);
            }
        }
    }
}
