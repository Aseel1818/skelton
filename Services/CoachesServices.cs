using mycoachEpic2.Epic2Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace mycoachEpic2.Services
{
    public  class CoachesServices
    {
        public CoachesServices()
        {

        }


        public  List<Coaches> GetCoaches()
        {
            var list = new List<Coaches>
            {
                new Coaches
                {
                    coachFistName="Mohammad",
                    coachLastName="Hamayel",
                    coachPhoneNumber=0562158569,
                    coachLocation="Nablus",
                    coachQualifications="Bachelor of sports ",
                    coachGender="Male",
                    coachCources="Yoga",
                    coachAge=28

                },


                new Coaches
                {
                    coachFistName="Nasser",
                    coachLastName="Hamayel",
                    coachPhoneNumber=0562152569,
                    coachLocation="Nablus",
                    coachQualifications="Bachelor of sports ",
                    coachGender="Male",
                    coachCources="Dance",
                    coachAge=30

                }
            };
            

            return list;
        }


    }




}
