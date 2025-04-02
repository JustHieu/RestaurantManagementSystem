USE RestaurantDB;
GO

-- Bảng Beverage
CREATE TABLE Beverage (
    ID NVARCHAR(50) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Description NVARCHAR(MAX),
    Price DECIMAL(10,0) NOT NULL,
    Picture NVARCHAR(MAX)
);

-- Bảng MainDishes
CREATE TABLE MainDishes (
    ID NVARCHAR(50) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Description NVARCHAR(MAX),
    Price DECIMAL(10,0) NOT NULL,
    Picture NVARCHAR(MAX)
);

-- Bảng Starters
CREATE TABLE Starters (
    ID NVARCHAR(50) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Description NVARCHAR(MAX),
    Price DECIMAL(10,0) NOT NULL,
    Picture NVARCHAR(MAX)
);

-- Bảng Tables
CREATE TABLE Tables (
    TableID NVARCHAR(50) PRIMARY KEY,
    State BIT NOT NULL -- 0: Trống, 1: Đã đặt
);

-- Chèn dữ liệu mẫu vào bảng MainDishes
INSERT INTO MainDishes (ID, Name, Description, Price, Picture) VALUES
('1', 'Crispy Skin Chicken', 'Ricotta, radicchio, prosciutto salad, cabernet.', 33, 'Q:\CODE\...'),
('2', 'Flank Steak', 'Served medium rare, salad, mushroom sauce.', 35, 'Q:\CODE\...'),
('3', 'Ebony Fillet Steak', 'Truffle mash, pepper sauce.', 58, 'Q:\CODE\...'),
('4', 'Fish & Chips', 'Atlantic cod fillet, chips, salad, tartare, lemon.', 33, 'Q:\CODE\...'),
('5', 'Grilled Salmon', 'Fresh salmon fillet, asparagus, lemon butter sauce.', 45, 'Q:\CODE\...'),
('6', 'Lobster Pasta', 'Linguine pasta with lobster tail, garlic, white wine sauce.', 62, 'Q:\CODE\...'),
('7', 'BBQ Pork Ribs', 'Slow-cooked pork ribs with BBQ glaze, coleslaw.', 50, 'Q:\CODE\...'),
('8', 'Vegetarian Lasagna', 'Layers of pasta, spinach, ricotta, tomato sauce.', 30, 'Q:\CODE\...');

-- Chèn dữ liệu mẫu vào bảng Beverage
INSERT INTO Beverage (ID, Name, Description, Price, Picture) VALUES
('1', 'Prickly Pear Tonic', 'Prickly Pear, Chancaca, Key Lime, and Tonic', 12, 'Q:\CODE\...'),
('2', 'Tommys Margarita', 'Tequila, fresh lime juice, and orange liqueur', 13, 'Q:\CODE\...'),
('3', 'Chicha Morada', 'Purple Corn, Pineapple, Apple, Cinnamon', 12, 'Q:\CODE\...'),
('4', 'Better Boy', 'Tomato, Salt, Black Pepper, Lemon', 10, 'Q:\CODE\...'),
('5', 'Espresso Martini', 'Vodka, espresso, coffee liqueur.', 15, 'Q:\CODE\...'),
('6', 'Matcha Latte', 'Japanese matcha green tea, steamed milk.', 11, 'Q:\CODE\...'),
('7', 'Mango Smoothie', 'Fresh mango, yogurt, honey.', 12, 'Q:\CODE\...'),
('8', 'Classic Mojito', 'White rum, mint, lime, soda water.', 14, 'Q:\CODE\...');

INSERT INTO Starters (ID, Name, Description, Price, Picture) VALUES
('1', 'Purple Corn Tostada', 'Ricotta, goat cheese, beetroot and datterini.', 36, 'Q:\CODE\...'),
('2', 'Brunos Scribble', 'Culatello, Spalla Cotta, Mortadella, Culacciona.', 30, 'Q:\CODE\...'),
('3', 'Fresh Oysters Dozen', 'Our selection of fresh oysters, limes.', 59, 'Q:\CODE\...'),
('4', 'Wild Mushroom Arancini', 'Porcini purée, parmesan, basil.', 18, 'Q:\CODE\...'),
('5', 'Crispy Calamari', 'Deep-fried squid, lemon aioli, fresh herbs.', 28, 'Q:\CODE\...'),
('6', 'Cheese Platter', 'Assorted cheeses, nuts, honey, crackers.', 34, 'Q:\CODE\...'),
('7', 'Stuffed Bell Peppers', 'Bell peppers stuffed with quinoa, feta, and herbs.', 27, 'Q:\CODE\...'),
('8', 'Garlic Butter Shrimp', 'Shrimp sautéed in garlic butter, parsley.', 32, 'Q:\CODE\...');

-- Chèn dữ liệu mẫu vào bảng Tables
INSERT INTO Tables (TableID, State) VALUES
('1', 0), -- False
('2', 0), -- False
('3', 1), -- True
('4', 0), -- False
('5', 0), -- False
('6', 0), -- False
('7', 0), -- False
('8', 0), -- False
('9', 0), -- False
('10', 0), -- False
('11', 0), -- False
('12', 0); -- False
