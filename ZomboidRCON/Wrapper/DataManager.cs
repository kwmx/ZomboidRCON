using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using ZomboidRCON.Models;
using System.Linq;

namespace ZomboidRCON.Wrapper
{
    internal class DataManager
    {
        private LiteDatabase database;
        public DataManager(string dbPath)
        {
            database = new LiteDatabase(dbPath + ".zrdb");
            CreateDefault(database);
        }
        public List<Vehicle> Vehicles { get { return database.GetCollection<Vehicle>("vehicles").FindAll().ToList(); } }
        public List<Player> Players { get { return database.GetCollection<Player>("players").FindAll().ToList(); } }

        private void CreateDefault(LiteDatabase database)
        {
            if (!database.CollectionExists("Vehicles"))
            {
                var col = database.GetCollection<Vehicle>("vehicles");

                // Add default cars
                IEnumerable<Vehicle> vehicles = new List<Vehicle>()
                {
                    new Vehicle
                {
                    Name = "Chevalier Cerise Wagon",
                    Variants = new Variant[] {
                        new Variant
                        {
                            Title="Normal",
                            VariantID="Base.CarStationWagon",
                            imageID="Base.CarStationWagon",
                            isStock=true,
                        },
                        new Variant
                        {
                            Title="Wood Siding",
                            VariantID="Base.CarStationWagon2",
                            imageID="Base.CarStationWagon2",
                            isStock=true,
                        },
                    },
                    isStock = true,
                },
                    new Vehicle
                {
                    Name = "Chevalier Cossette",
                    Variants = new Variant[] {
                        new Variant
                        {
                            Title="Normal",
                            VariantID="Base.SportsCar",
                            imageID="Base.SportsCar",
                            isStock=true,
                        },
                    },
                    isStock = true,

                },
                    new Vehicle
                {
                    Name = "Chevalier D6",
                    Variants = new Variant[] {
                        new Variant
                        {
                            Title="Normal",
                            VariantID="Base.PickUpTruck",
                            imageID="Base.PickUpTruck",
                            isStock=true,
                        },
                        new Variant
                        {
                            Title="Fire Dept.",
                            VariantID="Base.PickUpTruckLightsFire",
                            imageID="Base.PickUpTruckLightsFire",
                            isStock=true,
                        },
                        new Variant
                        {
                            Title="Fossoil/Ranger",
                            VariantID="Base.PickUpTruckLights",
                            imageID="Base.PickUpTruckLights",
                            isStock=true,
                        },
                        new Variant
                        {
                            Title="McCoy Logging Co.",
                            VariantID="Base.PickUpTruckMccoy",
                            imageID="Base.PickUpTruckMccoy",
                            isStock=true,
                        },
                    },
                    isStock = true,

                },
                    new Vehicle
                {
                    Name = "Chevalier Dart",
                    Variants = new Variant[] {
                        new Variant
                        {
                            Title="Normal",
                            VariantID="Base.SmallCar",
                            imageID="Base.SmallCar",
                            isStock=true,
                        },
                    },
                    isStock = true,

                },
                    new Vehicle
                {
                    Name = "Chevalier Nyala",
                    Variants = new Variant[] {
                        new Variant
                        {
                            Title="Normal",
                            VariantID="Base.CarNormal",
                            imageID="Base.CarNormal",
                            isStock=true,
                        },
                        new Variant
                        {
                            Title="Ranger",
                            VariantID="Base.CarLights",
                            imageID="Base.CarLights",
                            isStock=true,
                        },
                        new Variant
                        {
                            Title="Police",
                            VariantID="Base.CarLightsPolice",
                            imageID="Base.CarLightsPolice",
                            isStock=true,
                        },
                        new Variant
                        {
                            Title="Taxi (yellow)",
                            VariantID="Base.CarTaxi",
                            imageID="Base.CarTaxi",
                            isStock=true,
                        },
                        new Variant
                        {
                            Title="Taxi (green)",
                            VariantID="Base.CarTaxi2",
                            imageID="Base.CarTaxi2",
                            isStock=true,
                        },
                    },
                    isStock = true,

                },
                    new Vehicle
                {
                    Name = "Chevalier Primani",
                    Variants = new Variant[] {
                        new Variant
                        {
                            Title="Normal",
                            VariantID="Base.ModernCar02",
                            imageID="Base.ModernCar02",
                            isStock=true,
                        },
                    },
                    isStock = true,

                },
                    new Vehicle
                {
                    Name = "Chevalier Step Van",
                    Variants = new Variant[] {
                        new Variant
                        {
                            Title="Normal",
                            VariantID="Base.StepVan",
                            imageID="Base.StepVan",
                            isStock=true,
                        },
                        new Variant
                        {
                            Title="Mail",
                            VariantID="Base.StepVanMail",
                            imageID="Base.StepVanMail",
                            isStock=true,
                        },
                        new Variant
                        {
                            Title="Kentucky Herald",
                            VariantID="Base.StepVan_Heralds",
                            imageID="Base.StepVan_Heralds",
                            isStock=true,
                        },
                        new Variant
                        {
                            Title="Scarlet Oak Distillery",
                            VariantID="Base.StepVan_Scarlet",
                            imageID="Base.StepVan_Scarlet",
                            isStock=true,
                        },
                    },
                    isStock = true,

                },
                    new Vehicle
                {
                    Name = "Dash Bulldriver",
                    Variants = new Variant[] {
                        new Variant
                        {
                            Title="Normal",
                            VariantID="Base.PickUpVan",
                            imageID="Base.PickUpVan",
                            isStock=true,
                        },
                        new Variant
                        {
                            Title="Fossoil/Ranger",
                            VariantID="Base.PickUpVanLights",
                            imageID="Base.PickUpVanLights",
                            isStock=true,
                        },
                        new Variant
                        {
                            Title="Fire Dept.",
                            VariantID="Base.PickUpVanLightsFire",
                            imageID="Base.PickUpVanLightsFire",
                            isStock=true,
                        },
                        new Variant
                        {
                            Title="Police",
                            VariantID="Base.PickUpVanLightsPolice",
                            imageID="Base.PickUpVanLightsPolice",
                            isStock=true,
                        },
                        new Variant
                        {
                            Title="McCoy Logging Co.",
                            VariantID="Base.PickUpVanMccoy",
                            imageID="Base.PickUpVanMccoy",
                            isStock=true,
                        },
                    },
                    isStock = true,

                },
                    new Vehicle
                {
                    Name = "Dash Elite",
                    Variants = new Variant[] {
                        new Variant
                        {
                            Title="Normal",
                            VariantID="Base.ModernCar",
                            imageID="Base.ModernCar",
                            isStock=true,
                        },
                    },
                    isStock = true,

                },
                    new Vehicle
                {
                    Name = "Dash Rancher",
                    Variants = new Variant[] {
                        new Variant
                        {
                            Title="Normal",
                            VariantID="Base.OffRoad",
                            imageID="Base.OffRoad",
                            isStock=true,
                        },
                    },
                    isStock = true,

                },
                    new Vehicle
                {
                    Name = "Franklin All-Terrain",
                    Variants = new Variant[] {
                        new Variant
                        {
                            Title="Normal",
                            VariantID="Base.SUV",
                            imageID="Base.SUV",
                            isStock=true,
                        },
                    },
                    isStock = true,

                },
                    new Vehicle
                {
                    Name = "Franklin Valuline",
                    Variants = new Variant[] {
                        new Variant
                        {
                            Title="Normal",
                            VariantID="Base.Van",
                            imageID="Base.Van",
                            isStock=true,
                        },
                        new Variant
                        {
                            Title="6-Seater",
                            VariantID="Base.VanSeats",
                            imageID="Base.VanSeats",
                            isStock=true,
                        },
                        new Variant
                        {
                            Title="Ambulance",
                            VariantID="Base.VanAmbulance",
                            imageID="Base.VanAmbulance",
                            isStock=true,
                        },
                        new Variant
                        {
                            Title="Radio Van",
                            VariantID="Base.VanRadio",
                            imageID="Base.VanRadio",
                            isStock=true,
                        },
                        new Variant
                        {
                            Title="3N Radio Van",
                            VariantID="Base.VanRadio_3N",
                            imageID="Base.VanRadio_3N",
                            isStock=true,
                        },
                        new Variant
                        {
                            Title="Spiffo's",
                            VariantID="Base.VanSpiffo",
                            imageID="Base.VanSpiffo",
                            isStock=true,
                        },
                        new Variant
                        {
                            Title="Transit",
                            VariantID="Base.Van_Transit",
                            imageID="Base.Van_Transit",
                            isStock=true,
                        },
                        new Variant
                        {
                            Title="Mass GenFac",
                            VariantID="Base.Van_MassGenFac",
                            imageID="Base.Van_MassGenFac",
                            isStock=true,
                        },
                        new Variant
                        {
                            Title="Knox Distillery",
                            VariantID="Base.Van_KnoxDisti",
                            imageID="Base.Van_KnoxDisti",
                            isStock=true,
                        },
                        new Variant
                        {
                            Title="Lectro Max",
                            VariantID="Base.Van_LectroMax",
                            imageID="Base.Van_LectroMax",
                            isStock=true,
                        },
                        new Variant
                        {
                            Title="Fossoil",
                            VariantID="Base.VanSpecial",
                            imageID="Base.VanSpecial",
                            isStock=true,
                        },
                    },
                    isStock = true,

                },
                    new Vehicle
                {
                    Name = "Masterson Horizon",
                    Variants = new Variant[] {
                        new Variant
                        {
                            Title="Normal",
                            VariantID="Base.SmallCar02",
                            imageID="Base.SmallCar02",
                            isStock=true,
                        },
                    },
                    isStock = true,

                },
                    new Vehicle
                {
                    Name = "Mercia Lang 4000",
                    Variants = new Variant[] {
                        new Variant
                        {
                            Title="Normal",
                            VariantID="Base.CarLuxury",
                            imageID="Base.CarLuxury",
                            isStock=true,
                        },
                    },
                    isStock = true,

                },
                    new Vehicle
                {
                    Name = "Trailer",
                    Variants = new Variant[] {
                        new Variant
                        {
                            Title="Normal",
                            VariantID="Base.Trailer",
                            imageID="Base.Trailer",
                            isStock=true,
                        },
                        new Variant
                        {
                            Title="Cover",
                            VariantID="Base.TrailerCover",
                            imageID="Base.TrailerCover",
                            isStock=true,
                        },
                    },
                    isStock = true,

                },
                    new Vehicle
                {
                    Name = "Advert Trailer",
                    Variants = new Variant[] {
                        new Variant
                        {
                            Title="Normal",
                            VariantID="Base.TrailerAdvert",
                            imageID="Base.TrailerAdvert",
                            isStock=true,
                        },
                    },
                    isStock = true,

                },
                };
                col.InsertBulk(vehicles);
            }
            if (!database.CollectionExists("Items"))
            {

            }
            if (!database.CollectionExists("Players"))
            {
                var col = database.GetCollection<Player>("players");
                col.EnsureIndex(x => x.Name,true);
            }
        }
        public void AddPlayer(Player player)
        {
            var col = database.GetCollection<Player>("players");
            if (col.Exists(Query.EQ("Name", player.Name)))
            {
                Player p = col.FindOne(x => x.Name.Equals(player.Name));
                p.isOnline = true;
                col.Update(p);
                return;
            }
            col.Insert(player);
        }
        public void AddPlayer(IEnumerable<Player> players)
        {
            var col = database.GetCollection<Player>("players");
            col.InsertBulk(players);
        }
        public void AddVehicle(Vehicle vehicle)
        {
            var col = database.GetCollection<Vehicle>("vehicles");
            col.Insert(vehicle);
        }
        
        public void AddItem(Item item)
        {
            var col = database.GetCollection<Item>("items");
            col.Insert(item);
        }
        public void SetAllPlayersOffline()
        {
            var col = database.GetCollection<Player>("players");
            col.UpdateMany(p => new Player { Name = p.Name, isOnline = false, accessLevel = p.accessLevel}, p => p.isOnline == true);
        }
    }
}
