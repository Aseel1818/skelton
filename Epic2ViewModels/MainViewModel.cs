using mycoachEpic2.Epic2Models;
using mycoachEpic2.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace mycoachEpic2.Epic2ViewModels
{
    public class MainViewModel : ViewModelBase
    {

        public  MainViewModel(){


            var service = new CoachesServices();


            coachesList=service.GetCoaches();



        }
        private List<Coaches> CoachesList;

        public List<Coaches> coachesList
        {
            get { return coachesList; }
            set { setProperty(ref CoachesList, value); }
        }


    }
}
