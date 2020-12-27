using System;

public class XSClubPromoter:Promoter, IVlogger, IBodyBuilder{

        public XSClubPromoter(string firstName, string lastName, long contactNo):base(firstName, lastName, contactNo){

        }

        protected override void ShareWithInnerCircle(){
                Console.WriteLine("I share with my Instagram Followers");
        }

        protected override void UsePaidAds(){
                Console.WriteLine("I use Facebook Ads");

        }

        public void Vlog(){
                Console.WriteLine("I use a DSLR in order to vlog");

        }

        public void Workout(){
                Console.WriteLine("I workout at my house");

        }

}