const products = [
    {
        id: 0,
        title: "Wireless Headphones",
        description: "Noise cancelling over-ear headphones with deep bass.",
        category: "electronics",

        imgPath: ["headphones1.jpg", "headphones2.jpg", "headphones3.jpg"],

        price: 120,
        discount: 15,

        ratingCount: 50456,
        ratingPoint: 3.4,

        comments: [
            { userId: 1, content: "Great sound quality", likes: 55, dislikes: 2, givenRating: 5 },
            { userId: 2, content: "Very comfortable", likes: 30, dislikes: 1, givenRating: 4 }
        ],
    },
    {
        id: 1,
        title: "Gaming Mouse",
        description: "RGB high precision gaming mouse.",
        category: "electronics",

        imgPath: ["mouse1.jpg", "mouse2.jpg"],

        price: 45,
        discount: 10,

        ratingCount: 1000001,
        ratingPoint: 4.0,

        comments: [
            { userId: 3, content: "Super smooth tracking", likes: 40, dislikes: 3, givenRating: 5 }
        ],
    },
    {
        id: 2,
        title: "Mechanical Keyboard",
        description: "Blue switch mechanical keyboard with LED backlight.",
        category: "electronics",

        imgPath: ["keyboard1.jpg", "keyboard2.jpg", "keyboard3.jpg"],

        price: 85,
        discount: 20,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 4, content: "Clicky and satisfying", likes: 60, dislikes: 5, givenRating: 5 },
            { userId: 5, content: "A bit loud but good", likes: 20, dislikes: 4, givenRating: 4 }
        ],
    },
    {
        id: 3,
        title: "Smart Watch",
        description: "Fitness tracking smartwatch with heart monitor.",
        category: "electronics",

        imgPath: ["watch1.jpg", "watch2.jpg", "watch3.jpg"],

        price: 99,
        discount: 25,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 6, content: "Battery lasts long", likes: 70, dislikes: 2, givenRating: 5 }
        ],
    },
    {
        id: 4,
        title: "Bluetooth Speaker",
        description: "Portable waterproof speaker with deep sound.",
        category: "electronics",

        imgPath: ["speaker1.jpg", "speaker2.jpg"],

        price: 60,
        discount: 12,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 7, content: "Loud and clear", likes: 50, dislikes: 3, givenRating: 5 }
        ],
    },

    {
        id: 5,
        title: "Running Shoes",
        description: "Lightweight breathable running shoes.",
        category: "fashion",

        imgPath: ["shoes1.jpg", "shoes2.jpg", "shoes3.jpg"],

        price: 70,
        discount: 18,

        ratingCount: 4907990523,
        ratingPoint: 4.9,

        comments: [
            { userId: 8, content: "Very comfortable for running", likes: 80, dislikes: 1, givenRating: 5 }
        ],
    },
    {
        id: 6,
        title: "Backpack",
        description: "Water-resistant travel backpack with laptop compartment.",
        category: "fashion",

        imgPath: ["backpack1.jpg", "backpack2.jpg", "backpack3.jpg"],

        price: 55,
        discount: 10,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 9, content: "Very spacious and durable", likes: 65, dislikes: 2, givenRating: 5 }
        ],
    },
    {
        id: 7,
        title: "Sunglasses",
        description: "UV protection stylish sunglasses.",
        category: "fashion",

        imgPath: ["sunglasses1.jpg"],

        price: 35,
        discount: 5,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 10, content: "Looks stylish", likes: 40, dislikes: 2, givenRating: 4 }
        ],
    },
    {
        id: 8,
        title: "Smartphone",
        description: "Latest generation smartphone with AMOLED display.",
        category: "electronics",

        imgPath: ["phone1.jpg", "phone2.jpg", "phone3.jpg"],

        price: 699,
        discount: 12,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 11, content: "Insane camera quality", likes: 200, dislikes: 5, givenRating: 5 },
            { userId: 12, content: "Very fast performance", likes: 150, dislikes: 6, givenRating: 5 }
        ],
    },
    {
        id: 9,
        title: "Laptop",
        description: "High performance laptop for work and gaming.",
        category: "electronics",

        imgPath: ["laptop1.jpg", "laptop2.jpg", "laptop3.jpg"],

        price: 1200,
        discount: 8,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 13, content: "Perfect for development", likes: 180, dislikes: 3, givenRating: 5 }
        ],
    },
    {
        id: 10,
        title: "Office Chair",
        description: "Ergonomic adjustable office chair with lumbar support.",
        category: "furniture",

        imgPath: ["chair1.jpg", "chair2.jpg", "chair3.jpg"],

        price: 150,
        discount: 18,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 14, content: "Very comfortable for long work hours", likes: 75, dislikes: 3, givenRating: 5 }
        ],
    },
    {
        id: 11,
        title: "Desk Lamp",
        description: "LED desk lamp with adjustable brightness and color modes.",
        category: "furniture",

        imgPath: ["lamp1.jpg"],

        price: 25,
        discount: 8,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 15, content: "Perfect for night studying", likes: 40, dislikes: 1, givenRating: 5 }
        ],
    },
    {
        id: 12,
        title: "Coffee Maker",
        description: "Automatic drip coffee machine for home use.",
        category: "home",

        imgPath: ["coffee1.jpg", "coffee2.jpg", "coffee3.jpg"],

        price: 80,
        discount: 12,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 16, content: "Makes great coffee fast", likes: 55, dislikes: 2, givenRating: 5 }
        ],
    },
    {
        id: 13,
        title: "Water Bottle",
        description: "Insulated stainless steel water bottle.",
        category: "home",

        imgPath: ["bottle1.jpg", "bottle2.jpg"],

        price: 20,
        discount: 5,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 17, content: "Keeps water cold all day", likes: 35, dislikes: 0, givenRating: 5 }
        ],
    },
    {
        id: 14,
        title: "Dumbbells Set",
        description: "Adjustable dumbbells for home workout.",
        category: "fitness",

        imgPath: ["dumbbells1.jpg", "dumbbells2.jpg", "dumbbells3.jpg"],

        price: 90,
        discount: 15,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 18, content: "Solid build quality", likes: 80, dislikes: 2, givenRating: 5 }
        ],
    },
    {
        id: 15,
        title: "Yoga Mat",
        description: "Non-slip yoga mat for exercise and stretching.",
        category: "fitness",

        imgPath: ["yoga1.jpg", "yoga2.jpg", "yoga3.jpg"],

        price: 30,
        discount: 10,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 19, content: "Good grip and comfortable", likes: 60, dislikes: 1, givenRating: 5 }
        ],
    },
    {
        id: 16,
        title: "Tablet",
        description: "10-inch tablet for entertainment and work.",
        category: "electronics",

        imgPath: ["tablet1.jpg", "tablet2.jpg", "tablet3.jpg"],

        price: 250,
        discount: 20,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 20, content: "Very smooth performance", likes: 120, dislikes: 4, givenRating: 5 }
        ],
    },
    {
        id: 17,
        title: "Monitor",
        description: "24-inch Full HD monitor for office and gaming.",
        category: "electronics",

        imgPath: ["monitor1.jpg", "monitor2.jpg"],

        price: 180,
        discount: 14,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 21, content: "Sharp display and great colors", likes: 95, dislikes: 2, givenRating: 5 }
        ],
    },
    {
        id: 18,
        title: "Microwave Oven",
        description: "Compact microwave oven for quick heating.",
        category: "home",

        imgPath: ["microwave1.jpg", "microwave2.jpg", "microwave3.jpg"],

        price: 110,
        discount: 10,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 22, content: "Heats food quickly and evenly", likes: 70, dislikes: 3, givenRating: 5 }
        ],
    },
    {
        id: 19,
        title: "Blender",
        description: "High-speed kitchen blender for smoothies.",
        category: "home",

        imgPath: ["blender1.jpg", "blender2.jpg"],

        price: 65,
        discount: 12,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 23, content: "Very powerful motor", likes: 65, dislikes: 1, givenRating: 5 }
        ],
    },
    {
        id: 20,
        title: "Gaming Laptop Cooling Pad",
        description: "RGB cooling pad for laptops with adjustable fan speed.",
        category: "electronics",

        imgPath: ["coolingpad1.jpg", "coolingpad2.jpg", "coolingpad3.jpg"],

        price: 35,
        discount: 15,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 24, content: "Keeps laptop very cool", likes: 50, dislikes: 2, givenRating: 5 }
        ],
    },
    {
        id: 21,
        title: "Wireless Earbuds",
        description: "Compact earbuds with noise isolation and charging case.",
        category: "electronics",

        imgPath: ["earbuds1.jpg", "earbuds2.jpg"],

        price: 55,
        discount: 20,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 25, content: "Great battery life", likes: 90, dislikes: 3, givenRating: 5 },
            { userId: 26, content: "Good sound for price", likes: 60, dislikes: 4, givenRating: 4 }
        ],
    },
    {
        id: 22,
        title: "Smart LED Bulb",
        description: "Color changing smart bulb with app control.",
        category: "home",

        imgPath: ["bulb1.jpg", "bulb2.jpg", "bulb3.jpg"],

        price: 18,
        discount: 10,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 27, content: "Cool lighting effects", likes: 45, dislikes: 1, givenRating: 5 }
        ],
    },
    {
        id: 23,
        title: "Air Fryer",
        description: "Oil-free air fryer for healthy cooking.",
        category: "home",

        imgPath: ["airfryer1.jpg", "airfryer2.jpg", "airfryer3.jpg"],

        price: 95,
        discount: 18,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 28, content: "Makes crispy food easily", likes: 120, dislikes: 5, givenRating: 5 }
        ],
    },
    {
        id: 24,
        title: "Electric Kettle",
        description: "Fast boiling stainless steel electric kettle.",
        category: "home",

        imgPath: ["kettle1.jpg", "kettle2.jpg"],

        price: 40,
        discount: 12,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 29, content: "Boils water very fast", likes: 80, dislikes: 2, givenRating: 5 }
        ],
    },
    {
        id: 25,
        title: "Fitness Smart Band",
        description: "Lightweight fitness tracker with step counter.",
        category: "electronics",

        imgPath: ["band1.jpg", "band2.jpg", "band3.jpg"],

        price: 30,
        discount: 25,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 30, content: "Very accurate tracking", likes: 95, dislikes: 3, givenRating: 5 }
        ],
    },
    {
        id: 26,
        title: "Desk Organizer",
        description: "Multi-compartment desk storage organizer.",
        category: "furniture",

        imgPath: ["organizer1.jpg", "organizer2.jpg"],

        price: 22,
        discount: 5,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 31, content: "Keeps desk clean", likes: 55, dislikes: 1, givenRating: 5 }
        ],
    },
    {
        id: 27,
        title: "Portable Hard Drive",
        description: "1TB external storage drive USB 3.0.",
        category: "electronics",

        imgPath: ["hdd1.jpg", "hdd2.jpg", "hdd3.jpg"],

        price: 70,
        discount: 15,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 32, content: "Fast transfer speed", likes: 85, dislikes: 2, givenRating: 5 }
        ],
    },
    {
        id: 28,
        title: "Gaming Chair",
        description: "Ergonomic gaming chair with adjustable height.",
        category: "furniture",

        imgPath: ["gamingchair1.jpg", "gamingchair2.jpg", "gamingchair3.jpg"],

        price: 180,
        discount: 22,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 33, content: "Very comfortable for long sessions", likes: 150, dislikes: 4, givenRating: 5 }
        ],
    },
    {
        id: 29,
        title: "Smart Door Lock",
        description: "Fingerprint smart lock with mobile app control.",
        category: "home",

        imgPath: ["lock1.jpg", "lock2.jpg", "lock3.jpg"],

        price: 140,
        discount: 20,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 34, content: "Very secure and modern", likes: 130, dislikes: 3, givenRating: 5 }
        ],
    },
    {
        id: 30,
        title: "Smart TV",
        description: "4K Ultra HD smart television with streaming apps.",
        category: "electronics",

        imgPath: ["tv1.jpg", "tv2.jpg", "tv3.jpg"],

        price: 450,
        discount: 20,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 35, content: "Amazing picture quality", likes: 180, dislikes: 4, givenRating: 5 }
        ],
    },
    {
        id: 31,
        title: "Router",
        description: "High-speed WiFi router with dual band support.",
        category: "electronics",

        imgPath: ["router1.jpg", "router2.jpg"],

        price: 60,
        discount: 15,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 36, content: "Strong and stable connection", likes: 90, dislikes: 2, givenRating: 5 }
        ],
    },
    {
        id: 32,
        title: "Hair Dryer",
        description: "Fast drying ionic hair dryer.",
        category: "home",

        imgPath: ["dryer1.jpg", "dryer2.jpg", "dryer3.jpg"],

        price: 40,
        discount: 10,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 37, content: "Dries hair very fast", likes: 70, dislikes: 1, givenRating: 5 }
        ],
    },
    {
        id: 33,
        title: "Electric Toothbrush",
        description: "Rechargeable sonic electric toothbrush.",
        category: "home",

        imgPath: ["brush1.jpg", "brush2.jpg"],

        price: 35,
        discount: 12,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 38, content: "Teeth feel very clean", likes: 80, dislikes: 2, givenRating: 5 }
        ],
    },
    {
        id: 34,
        title: "Camera DSLR",
        description: "Professional DSLR camera for photography.",
        category: "electronics",

        imgPath: ["camera1.jpg", "camera2.jpg", "camera3.jpg"],

        price: 800,
        discount: 10,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 39, content: "Excellent image quality", likes: 250, dislikes: 5, givenRating: 5 }
        ],
    },
    {
        id: 35,
        title: "Tripod Stand",
        description: "Adjustable tripod for cameras and phones.",
        category: "electronics",

        imgPath: ["tripod1.jpg", "tripod2.jpg"],

        price: 25,
        discount: 8,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 40, content: "Very stable and useful", likes: 60, dislikes: 1, givenRating: 5 }
        ],
    },
    {
        id: 36,
        title: "Laptop Bag",
        description: "Water-resistant padded laptop carrying bag.",
        category: "fashion",

        imgPath: ["laptopbag1.jpg", "laptopbag2.jpg", "laptopbag3.jpg"],

        price: 40,
        discount: 15,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 41, content: "Perfect fit for laptop", likes: 85, dislikes: 2, givenRating: 5 }
        ],
    },
    {
        id: 37,
        title: "Perfume",
        description: "Long-lasting premium fragrance.",
        category: "fashion",

        imgPath: ["perfume1.jpg", "perfume2.jpg"],

        price: 55,
        discount: 10,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 42, content: "Smells amazing", likes: 90, dislikes: 1, givenRating: 5 }
        ],
    },
    {
        id: 38,
        title: "Sneakers",
        description: "Casual comfortable everyday sneakers.",
        category: "fashion",

        imgPath: ["sneakers1.jpg", "sneakers2.jpg", "sneakers3.jpg"],

        price: 75,
        discount: 18,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 43, content: "Very stylish and comfy", likes: 140, dislikes: 3, givenRating: 5 }
        ],
    },
    {
        id: 39,
        title: "Gym Bag",
        description: "Large capacity sports and gym bag.",
        category: "fitness",

        imgPath: ["gymbag1.jpg", "gymbag2.jpg"],

        price: 35,
        discount: 12,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 44, content: "Very spacious", likes: 80, dislikes: 2, givenRating: 5 }
        ],
    },
    {
        id: 40,
        title: "Treadmill",
        description: "Home electric treadmill for cardio workouts.",
        category: "fitness",

        imgPath: ["treadmill1.jpg", "treadmill2.jpg", "treadmill3.jpg"],

        price: 500,
        discount: 15,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 45, content: "Great for home workouts", likes: 200, dislikes: 5, givenRating: 5 }
        ],
    },
    {
        id: 41,
        title: "Bookshelf",
        description: "Wooden multi-layer bookshelf.",
        category: "furniture",

        imgPath: ["bookshelf1.jpg", "bookshelf2.jpg", "bookshelf3.jpg"],

        price: 120,
        discount: 20,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 46, content: "Very sturdy and stylish", likes: 120, dislikes: 3, givenRating: 5 }
        ],
    },
    {
        id: 42,
        title: "Wall Clock",
        description: "Modern silent wall clock.",
        category: "home",

        imgPath: ["clock1.jpg", "clock2.jpg"],

        price: 18,
        discount: 5,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 47, content: "Elegant design", likes: 60, dislikes: 1, givenRating: 5 }
        ],
    },
    {
        id: 43,
        title: "VR Headset",
        description: "Virtual reality headset for immersive gaming.",
        category: "electronics",

        imgPath: ["vr1.jpg", "vr2.jpg", "vr3.jpg"],

        price: 300,
        discount: 25,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 48, content: "Amazing experience", likes: 170, dislikes: 4, givenRating: 5 }
        ],
    },
    {
        id: 44,
        title: "Power Bank",
        description: "Fast charging portable power bank.",
        category: "electronics",

        imgPath: ["powerbank1.jpg", "powerbank2.jpg"],

        price: 45,
        discount: 10,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 49, content: "Charges phone quickly", likes: 100, dislikes: 2, givenRating: 5 }
        ],
    },
    {
        id: 45,
        title: "Rice Cooker",
        description: "Automatic electric rice cooker.",
        category: "home",

        imgPath: ["ricecooker1.jpg", "ricecooker2.jpg", "ricecooker3.jpg"],

        price: 70,
        discount: 15,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 50, content: "Rice comes out perfect", likes: 110, dislikes: 3, givenRating: 5 }
        ],
    },
    {
        id: 46,
        title: "Air Conditioner",
        description: "Energy efficient split AC unit.",
        category: "home",

        imgPath: ["ac1.jpg", "ac2.jpg", "ac3.jpg"],

        price: 600,
        discount: 20,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 51, content: "Cools room very fast", likes: 250, dislikes: 6, givenRating: 5 }
        ],
    },
    {
        id: 47,
        title: "Projector",
        description: "HD home theater projector.",
        category: "electronics",

        imgPath: ["projector1.jpg", "projector2.jpg"],

        price: 220,
        discount: 18,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 52, content: "Great movie experience", likes: 160, dislikes: 4, givenRating: 5 }
        ],
    },
    {
        id: 48,
        title: "Massage Gun",
        description: "Muscle recovery percussion massage gun.",
        category: "fitness",

        imgPath: ["massage1.jpg", "massage2.jpg", "massage3.jpg"],

        price: 85,
        discount: 22,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 53, content: "Relieves muscle pain fast", likes: 130, dislikes: 3, givenRating: 5 }
        ],
    },
    {
        id: 49,
        title: "Smart Mirror",
        description: "LED smart mirror with touch controls.",
        category: "home",

        imgPath: ["mirror1.jpg", "mirror2.jpg", "mirror3.jpg"],

        price: 180,
        discount: 20,

        ratingCount: 990123,
        ratingPoint: 4.9,

        comments: [
            { userId: 54, content: "Looks futuristic and clean", likes: 140, dislikes: 2, givenRating: 5 }
        ],
    }
];

export default products;
