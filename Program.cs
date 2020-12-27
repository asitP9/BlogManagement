using System;
using System.Collections.Generic;

namespace BlogManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Promoter> promoters=new List<Promoter>(){new XSClubPromoter("Jim", "Jones", 6185555555), new XSClubPromoter("Jane", "Jones", 6195555555), new OmniaClubPromoter("Jon", "Jones", 6175555555)};
            foreach(Promoter promoter in promoters){
                promoter.Promote();
            }
            
            List<Writer> writers=new List<Writer>(){new BookWriter("Jim", "Jones"), new BookWriter("Jane", "Jones"), new BlogWriter("Jon", "Jones")};
            foreach(Writer writer in writers){
                writer.Write();
            }
            
            List<IBodyBuilder> bodyBuilders=new List<IBodyBuilder>(){new XSClubPromoter("Jim", "Jones", 6185555555), new XSClubPromoter("Jane", "Jones", 6195555555)};
            foreach(IBodyBuilder bodyBuilder in bodyBuilders){
                bodyBuilder.Workout();
            }
            
            List<IVlogger> vloggers=new List<IVlogger>(){new BlogWriter("Jon", "Jones"), new XSClubPromoter("Jane", "Jones", 6195555555)};
            foreach(IVlogger vLogger in vloggers){
                vLogger.Vlog();
            }


            
        }
    }
}
