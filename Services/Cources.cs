using mycoachEpic2.Epic2Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace mycoachEpic2.Services
{
    public class CourcesServices
    {
        public CourcesServices()
        {

        }


        public List<Cources> GetCoaches()
        {
            var list = new List<Cources>
            {
                new Cources
                {
                   CourseName="Yoga",
                 CourseCoachFirstName="Mohammad",
                 CourseCoachLastName="Hamayel"
                },


                new Cources
                {
                   CourseName="Dance",
                 CourseCoachFirstName="Nasser",
                 CourseCoachLastName="Hamayel"
                },
            };


            return list;
        }


    }




}
