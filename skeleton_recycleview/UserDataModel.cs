using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skeleton_recycleview
{
    class UserDataModel
    {
        String name;
        String profession;
        String city;

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getProfession()
        {
            return profession;
        }

        public void setProfession(String profession)
        {
            this.profession = profession;
        }

        public String getCity()
        {
            return city;
        }

        public void setCity(String city)
        {
            this.city = city;
        }



    }
}