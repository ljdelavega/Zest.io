using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zest.Models
{
    public class Blog
    {
        public IList<BlogPost> blogposts { get; set; }

        public Blog()
        {
            populateBlogs();
        }

        private void populateBlogs()
        {
            blogposts = new List<BlogPost>();
            blogposts.Add(new BlogPost("10 Uses of Limes in Cocktails"
                , 1
                , DateTime.Now
                , "Team Zest"
                , @"All well-made cocktails are meant to bring out
                many different flavors on your palate. Just think about
                some of the best cocktails you’ve had — many have a punch
                of sour, which adds a deep, bright flavor. The secret? Often lime juice"
                , @"All well-made cocktails are meant to bring out many different flavors on your palate.
                Just think about some of the best cocktails you’ve had — many have a punch of sour, which adds a deep,
                bright flavor.
                The secret? Often lime juice — it’s not just a garnish on the rim of the glass.
                Without lime, some of the most popular
                and classic cocktails would fall flat (lime juice is key in the margarita and the gimlet).
                It helps balance a drink and downplay the strength of the alcohol, which usually means you end up drinking more in the end!

                We love the way limes work in cocktails, so we’ve rounded up some of the best lime-based cocktails from around the web.
                These drinks pack the pucker, but in a good way."
                ,"limes-large.jpg"));
            blogposts.Add(new BlogPost("Cooking With Lemon Juice"
                , 2
                , DateTime.Now
                , "Team Zest"
                , @"Most marinades are comprised of three parts: oil, spices and acid.
                The oil adds juiciness to the meat and the spices add flavor, but neither of those would have any affect on the meat without acid, the marinade superstar."
                , @"Most marinades are comprised of three parts: oil, spices and acid.
                The oil adds juiciness to the meat and the spices add flavor, but neither of those would have any affect on the meat without acid, the marinade superstar.


                Acids like lemon juice, lime juice and vinegar break down raw meat, allowing the marinade's oil and spices to deeply penetrate and infuse the meat with flavor
                and moisture.
                They dig out little pathways in the meat and allow the marinade to seep in.
                The scientific term for this breakdown is denaturation,
                which is the process in which protein loses its structure by application of a strong acid, base, salt, alcohol or heat.
                Basically, the scientific process that cooks meat with heat in the oven is the same one that cooks it with acid.
                The results may taste a little different -- fish cooked in the oven is flaky,
                whereas fish cooked by lemon juice (a.k.a. ceviche) has a more raw-tasting consistency -- but the process is the same."
                ,"lemons-large.jpg"));
        }
    }
}
