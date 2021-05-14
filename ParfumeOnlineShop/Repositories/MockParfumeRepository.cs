using ParfumeOnlineShop.Interfaces;
using ParfumeOnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfumeOnlineShop.Repositories
{
    public class MockParfumeRepository : IParfumeRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Parfume> Parfumes
        {
            get
            {
                return new List<Parfume>
                {
                    new Parfume{ParfumeId=1,Name="Bvlgari",Price=140.55M,ShortDescription="The elemental power of a woody fougere fragrance, crystallised by ice.",LongDescription="BVLGARI MAN GLACIAL ESSENCE enriches the Bvlgari Man collection dedicated to the power of natural elements. After fire and wood, Bvlgari Man explores air. BVLGARI MAN GLACIAL ESSENCE captures the unbridled magnitude of the frozen mountains and the unstoppable masculinity of a man on a constant quest for greatness.",Category=_categoryRepository.Categories.ToList()[0],ImageUrl="/Images/Menu/MBvlgari.jpg",InStock=true, IsParfumeOfTheMonth=false,ImageThumbnailUrl="/Images/MenuThumbnail/MBvlgari.jpg"},
                    new Parfume{ParfumeId=2,Name="Calvin Klein",Price=155.95M, ShortDescription="This came one day  ahead of scheduin a plastic sealed box(so obviously brand new) which is how it was described.",LongDescription="We have the Calvin Klein  line of colognes  and you will not believe the price. We have the Obsession Cologne and this cologne has a  bold design that smells great.",Category=_categoryRepository.Categories.ToList()[1],ImageUrl="/Images/Menu/MCalvinKlein.jpg",InStock=true,IsParfumeOfTheMonth=false, ImageThumbnailUrl="/Images/MenuThumbnail/MCalvinKlein.jpg"},
                    new Parfume{ParfumeId=3,Name="Dolce & Gabbana",Price=195.95M, ShortDescription="Dolce&Gabbana Light Blue featured in an exhibition at the Museum of Arts and Design in New York as one of the century’s most ground-breaking scents.",LongDescription="The Dolce&Gabbana Light Blue perfumes represent the aroma of sparkling summer days yielding to evocative evenings. They describe a story in which man meets woman. Domenico Dolce and Stefano Gabbana are extremely proud of Light Blue’s legacy, which includes several perfume awards.",Category=_categoryRepository.Categories.ToList()[0],ImageUrl="/Images/Menu/MDolceGabanna.jpg",InStock=true,IsParfumeOfTheMonth=true,ImageThumbnailUrl="/Images/MenuThumbnail/MDolceGabbana.jpg"},
                    new Parfume{ParfumeId=4,Name="Valentino",Price=205.65M,ShortDescription=" Born in Roma for him eau de toilette spray 100ml",LongDescription="The bottle pays a tribute to the iconic Valentino Rockstud. This small pyramidal shape, inspired by the magnificent Roman architecture, is the signature of Maison Valentino fashion. The elegant and classic black multifaceted bottle is made modern thanks to the daring pink Valentino signature. At Valentino, pink is punk.",Category=_categoryRepository.Categories.ToList()[1],ImageUrl="/Images/Menu/MValentino.jpg",InStock=true,IsParfumeOfTheMonth=true,ImageThumbnailUrl="/Images/MenuThumbnail/MValentino.jpg"}

                };
            }
        }

        public IEnumerable<Parfume> ParfumeOfTheMonth => throw new NotImplementedException();

        public Parfume GetParfumeById(int parfumeId)
        {
            throw new NotImplementedException();
        }
    }
}
