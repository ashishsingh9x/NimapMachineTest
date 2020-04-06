namespace ProductCategory.Business.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProductCategory.Business.Context.SqlDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProductCategory.Business.Context.SqlDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Categories.AddOrUpdate(
                p => p.Id,
                new Models.Category { Id = 1, Name = "Mobiles" },
                new Models.Category { Id = 2, Name = "Televisions" },
                new Models.Category { Id = 3, Name = "Laptops" },
                new Models.Category { Id = 4, Name = "Cameras" },
                new Models.Category { Id = 5, Name = "Watches" },
                new Models.Category { Id = 6, Name = "Pets Supplies" },
                new Models.Category { Id = 7, Name = "Books" },
                new Models.Category { Id = 8, Name = "Movies & TV Shows" },
                new Models.Category { Id = 9, Name = "Music" },
                new Models.Category { Id = 10, Name = "Video Games" },
                new Models.Category { Id = 11, Name = "Home & Kitchens" },
                new Models.Category { Id = 12, Name = "Car & Motorbike" },
                new Models.Category { Id = 13, Name = "Health" },
                new Models.Category { Id = 14, Name = "Luggage" },
                new Models.Category { Id = 15, Name = "Sports" }
                );

            context.Products.AddOrUpdate(
                p => p.Id,
                new Models.Product { Id = 1, Name = "USB Charge and Sync Cable", CategoryId = 1 },
                new Models.Product { Id = 2, Name = "Redmi Note 8", CategoryId = 1 },
                new Models.Product { Id = 3, Name = "Samsung Galaxy M31", CategoryId = 1 },
                new Models.Product { Id = 4, Name = "Redmi 8A Dual", CategoryId = 1 },
                new Models.Product { Id = 5, Name = "boAt Rockerz 255", CategoryId = 1 },
                new Models.Product { Id = 6, Name = "Redmi Note 9 Pro", CategoryId = 1 },
                new Models.Product { Id = 7, Name = "Mivi Thunderbeats", CategoryId = 1 },
                new Models.Product { Id = 8, Name = "Mi Powerbank", CategoryId = 1 },
                new Models.Product { Id = 9, Name = "Mi LED TV 4A PRO 108 cm (43 Inches) Full HD Android TV", CategoryId = 2 },
                new Models.Product { Id = 10, Name = "Vu 100 cm (40 inches) Full HD UltraAndroid LED TV 40GA (Black)", CategoryId = 2 },
                new Models.Product { Id = 11, Name = "Mi 80 cm (32 inches) 4C PRO HD Ready Android LED TV", CategoryId = 2 },
                new Models.Product { Id = 12, Name = "eAirtec 61 cm (24 inches) HD Ready LED TV 24DJ", CategoryId = 2 },
                new Models.Product { Id = 13, Name = "Onida 108 cm (43 Inches) Full HD Smart IPS LED TV", CategoryId = 2 },
                new Models.Product { Id = 14, Name = "LG 108 cm(43 inches) 4K UHD Smart LED TV 43UM7290PTF(Ceramic Black)", CategoryId = 2 },
                new Models.Product { Id = 15, Name = "Kodak 80 cm (32 Inches) HD Ready LED TV Kodak 32HDX900S", CategoryId = 2 },
                new Models.Product { Id = 16, Name = "Dell Vostro 3480 14-inch HD Thin & Light Laptop (Core i3 8th Gen/4GB/1TB HDD/Windows 10/Black/1.72kg)", CategoryId = 3 },
                new Models.Product { Id = 17, Name = "Apple MacBook Air (13-inch, Previous Model, 8GB RAM, 128GB Storage, 1.8GHz Intel Core i5) - Silver", CategoryId = 3 },
                new Models.Product { Id = 18, Name = "Dell Vostro 3581 15.6-inch HD Laptop (7th Gen Core i3-7020U/4GB/1TB HDD/Windows 10 + MS Office/Intel HD Graphics/Black)", CategoryId = 3 },
                new Models.Product { Id = 19, Name = "Lenovo V145-AMD-A6 15.6 inch HD Thin and Light Laptop (4GB RAM/ 500GB HDD/ Windows 10 Home with Lifetime Validity/ Black/ 2.1 kg), 81MT004BIH", CategoryId = 3 },
                new Models.Product { Id = 20, Name = "HP 14 Core i3 7th gen 14-inch Thin and Light Laptop (8GB/256GB SSD/Windows 10 Home/MS Office/Jet Black/1.43 kg), 14q-cs0023TU", CategoryId = 3 },
                new Models.Product { Id = 21, Name = "Lenovo Ideapad S145 AMD A6-9225 15.6 inch HD Thin and Light Laptop (4GB/1TB/Windows 10/Grey/1.85Kg), 81N30063IN", CategoryId = 3 },
                new Models.Product { Id = 22, Name = "ASUS TUF Gaming FX505DY-BQ002T 15.6-inch FHD Laptop (AMD Ryzen 5-3550H/8GB/1TB HDD/Windows 10/Radeon RX 560X 4GB Graphics/2.20 Kg), Black", CategoryId = 3 },
                new Models.Product { Id = 23, Name = "Mi 360° 1080p Full HD WiFi Smart Security Camera| 360° Viewing Area |Intruder Alert | Night Vision | Two-Way Audio |Inverted Installation", CategoryId = 4 },
                new Models.Product { Id = 24, Name = "Magideal Folded White Balance 18% Gray Reference Reflector Grey Card with Carry Bag", CategoryId = 4 },
                new Models.Product { Id = 25, Name = "TIZUM High Speed HDMI Cable with Ethernet - Supports 3D, 4K and Audio Return (1.8 Meter/ 6 Feet)", CategoryId = 4 },
                new Models.Product { Id = 26, Name = "Gizga Essentials GZ-CK-104 Professional 6-in-1 Cleaning Kit (Air Blower, Cotton Swabs, Suede + Plush Micro-Fiber Cloth, Brush,Cleaning Solution)", CategoryId = 4 },
                new Models.Product { Id = 27, Name = "Fujifilm Instax Mini Picture Format Film (20 Shots)", CategoryId = 4 },
                new Models.Product { Id = 28, Name = "Panasonic CR-2032/5BE Lithium Coin Battery - Pack of 5", CategoryId = 4 },
                new Models.Product { Id = 29, Name = "AmazonBasics 50-Inch Lightweight Tripod with Bag", CategoryId = 4 },
                new Models.Product { Id = 30, Name = "Fastrack Reflex 2.0 Activity Tracker - SWD90059PP05", CategoryId = 5 },
                new Models.Product { Id = 31, Name = "REDUX Analogue Day Date Functioning Men’s & Boy's Watch V216", CategoryId = 5 },
                new Models.Product { Id = 32, Name = "SKMEI S - Shock Blue Multi - Functional Analog Digital Sports Watch for Men's & Boys", CategoryId = 5 },
                new Models.Product { Id = 33, Name = "Fastrack Analog Dial Women's Watch (Pink, 6150SM04)-NK6150SM04", CategoryId = 5 },
                new Models.Product { Id = 34, Name = "Fossil Sport Smartwatch 43mm Black - FTW4019", CategoryId = 5 },
                new Models.Product { Id = 35, Name = "VILLS LAURRENS Analogue Black Dial Day and Date Series Men's Watch", CategoryId = 5 },
                new Models.Product { Id = 36, Name = "Sonata Super Fibre Analog Black Small Dial Men's Watch -NL7930PP01", CategoryId = 5 },
                new Models.Product { Id = 37, Name = "Pedigree Adult Wet Dog Food, Chicken & Liver Chunks in Gravy, 70 g", CategoryId = 6 },
                new Models.Product { Id = 38, Name = "Pedigree Adult Dry Dog Food, Chicken & Vegetables, 3kg Pack", CategoryId = 6 },
                new Models.Product { Id = 39, Name = "Whiskas Kitten (2-12 months) Dry Cat Food, Ocean Fish, 1.1kg Pack", CategoryId = 6 },
                new Models.Product { Id = 40, Name = "Meat Up Adult Dog Food, 3 kg (Buy 1 Get 1 Free)", CategoryId = 6 },
                new Models.Product { Id = 41, Name = "Drools Chicken and Egg Adult Dog Food, 3 kg with Free 1.2 kg", CategoryId = 6 },
                new Models.Product { Id = 42, Name = "Meat Up Kitten(1-12 months) Dry Cat Food, Ocean Fish, 1.2kg", CategoryId = 6 },
                new Models.Product { Id = 43, Name = "Choostix Chicken Dog Treat, 450g", CategoryId = 6 },
                new Models.Product { Id = 44, Name = "Death; An Inside Story: A book for all those who shall die", CategoryId = 7 },
                new Models.Product { Id = 45, Name = "The Power of your Subconscious Mind", CategoryId = 7 },
                new Models.Product { Id = 46, Name = "Ikigai: The Japanese secret to a long and happy life", CategoryId = 7 },
                new Models.Product { Id = 47, Name = "The Rudest Book Ever", CategoryId = 7 },
                new Models.Product { Id = 48, Name = "Think and Grow Rich", CategoryId = 7 },
                new Models.Product { Id = 49, Name = "Word Power Made Easy", CategoryId = 7 },
                new Models.Product { Id = 50, Name = "505 Activities for Kids", CategoryId = 7 },
                new Models.Product { Id = 51, Name = "Hasbro Sorry Game", CategoryId = 8 },
                new Models.Product { Id = 52, Name = "Super 30", CategoryId = 8 },
                new Models.Product { Id = 53, Name = "The Sound of Music", CategoryId = 8 },
                new Models.Product { Id = 54, Name = "2012", CategoryId = 8 },
                new Models.Product { Id = 55, Name = "Manchester By the Sea", CategoryId = 8 },
                new Models.Product { Id = 56, Name = "Harry Potter and the Chamber of Secrets", CategoryId = 8 },
                new Models.Product { Id = 57, Name = "Angry Birds", CategoryId = 8 },
                new Models.Product { Id = 58, Name = "Forever Puncham", CategoryId = 9 },
                new Models.Product { Id = 59, Name = "Music to BE Murdered by", CategoryId = 9 },
                new Models.Product { Id = 60, Name = "Brazilian Nights", CategoryId = 9 },
                new Models.Product { Id = 61, Name = "The Melody Queen-Lata Mangeshkar", CategoryId = 9 },
                new Models.Product { Id = 62, Name = "All Time Favourites - Mukesh", CategoryId = 9 },
                new Models.Product { Id = 63, Name = "Andaaz Khushi Ka: Mohd.Rafi", CategoryId = 9 },
                new Models.Product { Id = 64, Name = "101 Kishore Kumar Hits", CategoryId = 9 },
                new Models.Product { Id = 65, Name = "AmazonBasics Extended Gaming Mouse Pad,Black", CategoryId = 10 },
                new Models.Product { Id = 66, Name = "Redgear Smartline Wired Gamepad", CategoryId = 10 },
                new Models.Product { Id = 67, Name = "PS4 God of War (PS4)", CategoryId = 10 },
                new Models.Product { Id = 68, Name = "Redgear MP35 Speed-Type Gaming Mousepad (Black/Red)", CategoryId = 10 },
                new Models.Product { Id = 69, Name = "ZEBRONICS Gaming Multimedia USB Keyboard & USB Mouse Combo -Transformer", CategoryId = 10 },
                new Models.Product { Id = 70, Name = "FIFA 20 (PS4)", CategoryId = 10 },
                new Models.Product { Id = 71, Name = "Redgear Pro Wireless Gamepad", CategoryId = 10 },
                new Models.Product { Id = 72, Name = "LG 1 Ton 5 Star Inverter Split AC", CategoryId = 11 },
                new Models.Product { Id = 73, Name = "Mi 80 cm (32 inches) 4A Pro HD Ready Android LED TV", CategoryId = 11 },
                new Models.Product { Id = 74, Name = "AmazonBasics 564 L Frost Free Side-by-Side Refrigerator with Water Dispenser", CategoryId = 11 },
                new Models.Product { Id = 75, Name = "Sanyo 1.5 Ton 5 Star Dual Inverter Wide Split AC", CategoryId = 11 },
                new Models.Product { Id = 76, Name = "Samsung 6.2 kg Fully-Automatic Top load Washing Machine", CategoryId = 11 },
                new Models.Product { Id = 77, Name = "KENT New Grand 8-Litres Wall-Mountable RO + UV+ UF + TDS (White) 20 litre/hr Water Purifier", CategoryId = 11 },
                new Models.Product { Id = 78, Name = "SleepX Ortho mattress - Memory foam (78*72*8 Inches)", CategoryId = 11 },
                new Models.Product { Id = 79, Name = "boAt Dual Port Rapid Car Charger ", CategoryId = 12 },
                new Models.Product { Id = 80, Name = "SOFTSPUN Microfiber Cloth", CategoryId = 12 },
                new Models.Product { Id = 81, Name = "Vocado Black Reusable Pollution Mask", CategoryId = 12 },
                new Models.Product { Id = 82, Name = "ELV Car Mount Adjustable Car Phone Holder Universal Long Arm, Windshield for Smartphones - Black", CategoryId = 12 },
                new Models.Product { Id = 83, Name = "Jopasu Car Duster", CategoryId = 12 },
                new Models.Product { Id = 84, Name = "Le Gear Dri-Fit Helmet Skull Cap (Black)", CategoryId = 12 },
                new Models.Product { Id = 85, Name = "Sheeba SCAIO07 All-in-One Multipurpose Liquid Polish (200 ml)", CategoryId = 12 },
                new Models.Product { Id = 86, Name = "Vim Anti Smell Bar", CategoryId = 13 },
                new Models.Product { Id = 87, Name = "Surf Excel Matic Liquid Detergent - 2 Litre Pouch", CategoryId = 13 },
                new Models.Product { Id = 88, Name = "Spotzero by Milton", CategoryId = 13 },
                new Models.Product { Id = 89, Name = "Dettol Original Soap", CategoryId = 13 },
                new Models.Product { Id = 90, Name = "RIN Detergent Bar", CategoryId = 13 },
                new Models.Product { Id = 91, Name = "Lizol Disinfectant Surface Cleaner", CategoryId = 13 },
                new Models.Product { Id = 92, Name = "Surf Excel Easy Wash Detergent Powder", CategoryId = 13 },
                new Models.Product { Id = 93, Name = "Women's PU Leather Handbag Combo", CategoryId = 14 },
                new Models.Product { Id = 94, Name = "Neck Travel Pillow Multipurpose", CategoryId = 14 },
                new Models.Product { Id = 95, Name = "Skybags", CategoryId = 14 },
                new Models.Product { Id = 96, Name = "F Gear", CategoryId = 14 },
                new Models.Product { Id = 97, Name = "Safari 15 Ltrs Sea Blue Casual / School / College Backpack ", CategoryId = 14 },
                new Models.Product { Id = 98, Name = "RFID Protected Genuine High Quality Leather Wallet for Men", CategoryId = 14 },
                new Models.Product { Id = 99, Name = "American Tourister Copa 22 Ltrs Black Casual Backpack", CategoryId = 14 },
                new Models.Product { Id = 100, Name = "Mi Band 3 (Black)", CategoryId = 15 },
                new Models.Product { Id = 101, Name = "Skipping-Rope Jump Skipping Rope for Men, Women, Weight Loss, Kids, Girls, Children, Adult - Best in Fitness, Sports, Exercise, Workout", CategoryId = 15 },
                new Models.Product { Id = 102, Name = "Yonex Mavis 350 Nylon Shuttlecock", CategoryId = 15 },
                new Models.Product { Id = 103, Name = "Yonex Mavis 200i Nylon Shuttle Cock", CategoryId = 15 },
                new Models.Product { Id = 104, Name = "Optimum Nutrition (ON) Gold Standard 100% Whey Protein Powder", CategoryId = 15 },
                new Models.Product { Id = 105, Name = "Fitkit Classic Bottle Shaker 700ml", CategoryId = 15 }
                );
        }
    }
}
