using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirarperestX
{
    public class Photoset
    {
        public string ID { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public DateTime Date { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Type { get; set; }

        public class PhotosetList : List<Photoset>
        {
            public object Key { get; set; }
        }
      
        public ObservableCollection<PhotosetList> getByCountryGrouped()
        {
            ObservableCollection<PhotosetList> result = new ObservableCollection<PhotosetList>();

            try
            {
                //Azure mobile apps query
                //var query = from photo in await photosetTable.Where(a => a.Country != null).ToListAsync()

                var query = from photo in getAllPhotos().Where(a => a.Country != null)
                            group photo by photo.Country into g
                            orderby g.Key
                            select new { GroupName = g.Key, Items = g };

                foreach (var g in query)
                {
                    PhotosetList info = new PhotosetList();
                    info.Key = g.GroupName;
                    foreach (var item in g.Items)
                    {
                        info.Add(item);
                    }
                    result.Add(info);
                }

                return result;
            }
            catch
            {
                return result;
            }
        }
        public List<Photoset> getAllPhotos()
        {

            List<Photoset> photoList = new List<Photoset>();
            photoList.Add(new Photoset { Thumbnail = "http://62.media.tumblr.com/6dc5e497d0bf0a105fb155444db80516/tumblr_ns2mavHjNZ1qg7dm4o5_500.jpg", Url = "http://ikivanc.tumblr.com/post/125101282274/petra-jordan-ürdünün-güney-kısmında-akabeye-çok", Title = "Petra", Description = "Description will be displayed here", Country = "Jordan", City = "Petra", Longitude = 35.47, Latitude = 30.32, Type = "Landscape" });
            photoList.Add(new Photoset { Thumbnail = "http://62.media.tumblr.com/9bba8a415d9ec9db5277d19c8d60bf2f/tumblr_ns2ls9SPrl1qg7dm4o5_500.jpg", Url = "http://ikivanc.tumblr.com/post/125042640234/urdun-amman-belki-de-buradaki-yak%C4%B1n", Title = "Amman", Description = "Description will be displayed here", Country = "Jordan", City = "Amman", Longitude = 35.94, Latitude = 31.95, Type = "Landscape" });
            photoList.Add(new Photoset { Thumbnail = "http://62.media.tumblr.com/f90f9abc09e5b8303636787654658446/tumblr_nir9jrfqPl1qg7dm4o2_500.jpg", Url = "http://ikivanc.tumblr.com/post/109147738454/aylarca-s&uuml;ren-i%C5%9F-seyahati-temposundan-dolay%C4%B1-son-6", Title = "London", Description = "Description will be displayed here", Country = "United Kingdom", City = "London", Longitude = -0.12, Latitude = 51.5, Type = "Landscape" });
            photoList.Add(new Photoset { Thumbnail = "http://40.media.tumblr.com/2c1e13b0d9e2e4c5152cbe5216d0f006/tumblr_nb36ojQE0o1qg7dm4o6_500.jpg", Url = "http://ikivanc.tumblr.com/post/96117958639/venedikte-bir-süre-kaldıktan-sonra-hızlı-tren-ile", Title = "Rome", Description = "Description will be displayed here", Country = "Italy", City = "Rome", Longitude = 12.48, Latitude = 41.89, Type = "Landscape" });
            photoList.Add(new Photoset { Thumbnail = "http://40.media.tumblr.com/988f46c536f364f7825b9b92d12b62a8/tumblr_n0ox1y056Q1qg7dm4o7_r1_500.jpg", Url = "http://ikivanc.tumblr.com/post/76020807776/venedik-gezisi-uzun-zaman-sonra-planlad%C4%B1%C4%9F%C4%B1m-ilk", Title = "Venice", Description = "Description will be displayed here", Country = "Italy", City = "Venice", Longitude = 12.33, Latitude = 45.43, Type = "Landscape" });
            photoList.Add(new Photoset { Thumbnail = "http://40.media.tumblr.com/7b286d1537fd553897477f8d448c47c3/tumblr_n0cccphMir1qg7dm4o1_500.jpg", Url = "http://ikivanc.tumblr.com/post/75304496243/daha-&ouml;nceden-almanyaya-var%C5%9Fova-u&ccedil;a%C4%9F%C4%B1n%C4%B1", Title = "Munich", Description = "Description will be displayed here", Country = "Germany", City = "Munich", Longitude = 11.58, Latitude = 48.13, Type = "Landscape" });
            photoList.Add(new Photoset { Thumbnail = "http://40.media.tumblr.com/4c7656fe18e2393455d8aeb82adabad0/tumblr_mz9cuuzMAL1qg7dm4o2_500.jpg", Url = "http://ikivanc.tumblr.com/post/73021224629/uzun-zamandır-fotoğraf-çekemiyorum-belki-de", Title = "Doha", Description = "Description will be displayed here", Country = "Qatar", City = "Doha", Longitude = 51.52, Latitude = 25.28, Type = "Landscape" });
            photoList.Add(new Photoset { Thumbnail = "http://62.media.tumblr.com/2ed5c2a9a1bab474eeab4670c4a41824/tumblr_mtvr1oZk2r1qg7dm4o1_500.jpg", Url = "http://ikivanc.tumblr.com/post/62594689770/lake-nakurunairobi-kenya-2", Title = "Safari I", Description = "Description will be displayed here", Country = "Kenya", City = "Nairobi", Longitude = 36.1, Latitude = -0.35, Type = "Landscape" });
            photoList.Add(new Photoset { Thumbnail = "http://36.media.tumblr.com/34ec5dae6ad2b5e8df2a7ba2f6a68327/tumblr_mtupv5yLKp1qg7dm4o4_500.jpg", Url = "http://ikivanc.tumblr.com/post/62536866681/i%C5%9F-gezisi-ve-tak%C4%B1m-toplant%C4%B1s%C4%B1-i&ccedil;in-yaln%C4%B1z-kenyaya", Title = "Safari II", Description = "Description will be displayed here", Country = "Kenya", City = "Nairobi", Longitude = 36.1, Latitude = -0.35, Type = "Landscape" });
            photoList.Add(new Photoset { Thumbnail = "http://40.media.tumblr.com/737c901fa075378eea22db99feb9e2ed/tumblr_mse0avs5Lr1qg7dm4o8_500.jpg", Url = "http://ikivanc.tumblr.com/post/59851767779/&uuml;sk&uuml;dar-istanbul-turkey", Title = "Üsküdar", Description = "Description will be displayed here", Country = "Turkey", City = "Istanbul", Longitude = 29, Latitude = 41.02, Type = "Landscape" });
            photoList.Add(new Photoset { Thumbnail = "http://40.media.tumblr.com/0ac7794ea055d01898dceaddf430ff78/tumblr_mr25k9SQTG1qg7dm4o9_500.jpg", Url = "http://ikivanc.tumblr.com/post/57470776032/bu-sene-techready-i&ccedil;in-yine-microsoftun-ba%C5%9Fkenti", Title = "Seattle", Description = "Description will be displayed here", Country = "USA", City = "Seattle", Longitude = -112.32, Latitude = 47.6, Type = "Landscape" });
            photoList.Add(new Photoset { Thumbnail = "http://40.media.tumblr.com/2a2304e8afb0b403e1d20c6262aee90f/tumblr_mqq71kVLcK1qg7dm4o1_500.jpg", Url = "http://ikivanc.tumblr.com/post/57157802455/bu-sene-istanbuldan-seattlea-gidebilmek-i&ccedil;in", Title = "NewYork", Description = "Description will be displayed here", Country = "USA", City = "NewYork", Longitude = -70.01, Latitude = 40.71, Type = "Landscape" });
            photoList.Add(new Photoset { Thumbnail = "http://40.media.tumblr.com/cd2400210cd3dc2fb615c1adb59da767/tumblr_mpttlmWbfk1qg7dm4o4_500.jpg", Url = "http://ikivanc.tumblr.com/post/55468140968/10-y%C4%B1l-&ouml;nce-geldi%C4%9Fimde-hava-inan%C4%B1lmaz-kapal%C4%B1-ve", Title = "Çanakkale", Description = "Description will be displayed here", Country = "Turkey", City = "Çanakale", Longitude = 26.21, Latitude = 40.05, Type = "Landscape" });
            photoList.Add(new Photoset { Thumbnail = "http://62.media.tumblr.com/475680dba11980db043d41e7b90bedd0/tumblr_mptu51YUhT1qg7dm4o8_500.jpg", Url = "http://ikivanc.tumblr.com/post/55338756357/dubai-united-arab-emirates", Title = "Dubai", Description = "Description will be displayed here", Country = "United Arab Emirates", City = "Dubai", Longitude = 55.3, Latitude = 25.25, Type = "Landscape" });
            photoList.Add(new Photoset { Thumbnail = "http://40.media.tumblr.com/78b99e1e06971fcc6f87517120e35cd6/tumblr_mpisziu0KD1qg7dm4o10_500.jpg", Url = "http://ikivanc.tumblr.com/post/54755351689/paris-france", Title = "Paris", Description = "Description will be displayed here", Country = "France", City = "Paris", Longitude = 2.34, Latitude = 48.85, Type = "Landscape" });
            photoList.Add(new Photoset { Thumbnail = "http://36.media.tumblr.com/5eee2bd0c79edb30f332eecd2f483c03/tumblr_mp9oxaEtIf1qg7dm4o2_500.jpg", Url = "http://ikivanc.tumblr.com/post/54353661266/prague-czech-republic", Title = "Prague", Description = "Description will be displayed here", Country = "Czech Republic", City = "Prague", Longitude = 14.43, Latitude = 50.07, Type = "Landscape" });
            photoList.Add(new Photoset { Thumbnail = "http://61.media.tumblr.com/6941dcfd1b17aded326cd0b781bd090e/tumblr_moch1xqEKJ1qg7dm4o7_r1_1280.jpg", Url = "http://ikivanc.tumblr.com/post/53523490157/do%C4%9Fdu%C4%9Funuz-%C5%9Fehre-hi&ccedil;-turist-olarak-gittiniz-mi", Title = "Konya", Description = "Description will be displayed here", Country = "Turkey", City = "", Longitude = 32.49, Latitude = 37.87, Type = "Landscape" });
            photoList.Add(new Photoset { Thumbnail = "http://36.media.tumblr.com/f880cd5010eb80153eac3904cc9f35d9/tumblr_mnffsfASdH1qg7dm4o9_250.jpg", Url = "http://ikivanc.tumblr.com/post/51425384044/san%C4%B1r%C4%B1m-uzun-zaman-sonra-ilk-defa-bu-kadar-yeri", Title = "Istanbul", Description = "Description will be displayed here", Country = "Turkey", City = "Istanbul", Longitude = 28.95, Latitude = 41.02, Type = "Landscape" });
            photoList.Add(new Photoset { Thumbnail = "http://40.media.tumblr.com/eba98e7abfc004dc2e0a4be63dad26db/tumblr_nwhdo3QW531qg7dm4o8_500.jpg", Url = "http://ikivanc.tumblr.com/post/131503398369/sofia-bulgaria-avrupada-hangi-şehiree", Title = "Sofia", Description = "Description will be displayed here", Country = "Bulgaria", City = "Sofia", Longitude = 23.32, Latitude = 42.69, Type = "Landscape" });
            //photoList.Add(new Photoset { Thumbnail = "", Url = "", Title = "", Description = "Description will be displayed here", Country = "", City = "", Longitude = , Latitude = , Type = "Landscape" });
            return photoList;
        }
        public List<Photoset> getByCity(string cityName)
        {
            List<Photoset> result = (from photo in getAllPhotos()
                                     where photo.City == cityName
                                     select photo).ToList<Photoset>();

            return result;
        }
    }
}
