-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Хост: 127.0.0.1
-- Время создания: Дек 17 2015 г., 19:25
-- Версия сервера: 5.5.25
-- Версия PHP: 5.3.13

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- База данных: `kassa`
--

-- --------------------------------------------------------

--
-- Структура таблицы `checkhistory`
--

CREATE TABLE IF NOT EXISTS `checkhistory` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `sum` mediumtext,
  `datetime` mediumtext,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=6 ;

--
-- Дамп данных таблицы `checkhistory`
--

INSERT INTO `checkhistory` (`id`, `sum`, `datetime`) VALUES
(1, '89', '17.12.2015 18:12:36'),
(2, '66', '17.12.2015 18:14:17'),
(3, '200', '17.12.2015 18:18:31'),
(4, '800', '17.12.2015 18:20:19'),
(5, '45,77', '17.12.2015 18:21:25');

-- --------------------------------------------------------

--
-- Структура таблицы `login`
--

CREATE TABLE IF NOT EXISTS `login` (
  `idlogin` int(11) NOT NULL AUTO_INCREMENT,
  `username` mediumtext,
  `password` mediumtext,
  PRIMARY KEY (`idlogin`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Дамп данных таблицы `login`
--

INSERT INTO `login` (`idlogin`, `username`, `password`) VALUES
(1, 'admin', '1'),
(2, 'vlad', '1111');

-- --------------------------------------------------------

--
-- Структура таблицы `products`
--

CREATE TABLE IF NOT EXISTS `products` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` mediumtext,
  `price` double DEFAULT NULL,
  `type` longtext,
  `measure` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=153 ;

--
-- Дамп данных таблицы `products`
--

INSERT INTO `products` (`id`, `name`, `price`, `type`, `measure`) VALUES
(1, 'Milk', 2.5, 'Dairy', '1 l'),
(2, 'Сheese ', 5, 'Dairy', '1 kg'),
(3, 'Round steak', 19.32, 'Meat ', '1 kg'),
(4, 'Sirloin steak', 24.74, 'Meat ', '1 kg'),
(5, 'Prime rib roast', 30.76, 'Meat ', '1 kg'),
(6, 'Blade roast', 16.65, 'Meat ', '1 kg'),
(7, 'Stewing beef', 17.27, 'Meat ', '1 kg'),
(8, 'Ground beef, regular', 13.23, 'Meat ', '1 kg'),
(9, 'Pork chops', 13.26, 'Meat ', '1 kg'),
(10, 'Chicken', 7.82, 'Meat ', '1 kg'),
(11, 'Bacon', 6.86, 'Meat ', '500 g'),
(12, 'Wieners', 4.25, 'Dairy', '450 g'),
(13, 'Canned sockeye salmon', 4.47, 'Dairy', '413  g'),
(14, 'Homogenized milk', 2.47, 'Dairy', '1 l'),
(15, 'Partly skimmed milk', 2.33, 'Dairy', '1 l'),
(16, 'Butter', 4.67, 'Dairy', '454 g'),
(17, 'Processed cheese food slices', 3, 'Dairy', '250 g'),
(18, 'Processed cheese food slices', 1.86, 'Dairy', '385 ml'),
(19, 'Eggs', 3.33, 'Dairy', '1 dz'),
(20, 'Bread', 2.99, 'Bakery and confectionery', '675 g'),
(21, 'Milk', 2.5, 'Dairy', '1 l'),
(22, 'Сheese ', 5, 'Dairy', '1 kg'),
(23, 'Round steak', 19.32, 'Meat ', '1 kg'),
(24, 'Sirloin steak', 24.74, 'Meat ', '1 kg'),
(25, 'Prime rib roast', 30.76, 'Meat ', '1 kg'),
(26, 'Soda crackers', 2.92, 'Grocery', '450 g'),
(27, 'Macaroni', 1.64, 'Grocery', '500 g'),
(28, 'Flour', 4.95, 'Grocery', '2.5 kg'),
(29, 'Corn flakes', 5.03, 'Grocery', '675 g'),
(30, 'Apples', 4.13, 'Fruits and Vegetables', '1 kg'),
(31, 'Bananas', 1.65, 'Fruits and Vegetables', '1 kg'),
(32, 'Grapefruits', 3.61, 'Fruits and Vegetables', '1 kg'),
(33, 'Oranges', 3.56, 'Fruits and Vegetables', '1 kg'),
(34, 'Apple juice, canned', 2.17, 'Drinks', '1.36 l'),
(35, 'Orange juice, tetra-brick', 4, 'Drinks', '1 l'),
(36, 'Carrots', 1.7, 'Fruits and Vegetables', '1 kg'),
(37, 'Celery', 2.24, 'Fruits and Vegetables', '1 kg'),
(38, 'Mushrooms', 8.23, 'Fruits and Vegetables', '1 kg'),
(39, 'Onions', 1.34, 'Fruits and Vegetables', '1 kg'),
(40, 'Potatoes', 5.43, 'Fruits and Vegetables', '4.54 kg'),
(41, 'French fried potatoes, frozen', 2.59, 'Grocery', '1 kg'),
(42, 'Baked beans, canned', 1.99, 'Canned food', '398 ml'),
(43, 'Tomatoes, canned', 1.09, 'Canned food', '796 ml'),
(44, 'Tomato juice, canned', 2.4, 'Drinks', '1.36 l	'),
(45, 'Ketchup', 3.6, 'Canned food', '1 l'),
(46, 'Sugar, white', 2.35, 'Grocery', '2 kg'),
(47, 'Coffee, roasted', 6.45, 'Drinks', '300 g'),
(48, 'Coffee, instant', 7.64, 'Drinks', '200 g'),
(49, 'Tea (bags)', 4.72, 'Drinks', '72'),
(50, 'Cooking or salad oil', 4.81, 'Canned food', '1 l'),
(51, 'Soup, canned', 1.23, 'Canned food', '284 ml'),
(52, 'Baby food', 0.39, 'Baby', '128 ml'),
(53, 'Peanut butter', 3.49, NULL, '500 g'),
(54, 'Fruit flavoured crystals', 1.29, 'Drinks', '2.25 l'),
(55, 'Soft drinks, cola type', 1.5, 'Drinks', '2 l'),
(56, 'Soft drinks, lemon-lime type', 1.73, 'Drinks', '2 l'),
(57, 'Paper towels (rolls)', 2.44, 'Hygiene', '2 '),
(58, 'Facial tissue', 2.15, 'Hygiene', '200'),
(59, 'Bathroom tissue (rolls)', 2.25, 'Hygiene', '4'),
(60, 'Shampoo', 3.27, 'Hygiene', '300 ml'),
(61, 'Deodorant', 4.4, 'Hygiene', '60 g'),
(62, 'Toothpaste', 2.65, 'Hygiene', '100 ml'),
(63, 'Cigarettes', 97.75, 'Drinks', '200	'),
(64, 'Hershey''s Cinnamon Baking Chips', 2.38, 'Baking Chips', '283 g'),
(65, 'Milk', 2.5, 'Dairy', '1 l'),
(66, 'Сheese ', 5, 'Dairy', '1 kg'),
(67, 'Round steak', 19.32, 'Meat ', '1 kg'),
(68, 'Sirloin steak', 24.74, 'Meat ', '1 kg'),
(69, 'Prime rib roast', 30.76, 'Meat ', '1 kg'),
(70, 'Blade roast', 16.65, 'Meat ', '1 kg'),
(71, 'Stewing beef', 17.27, 'Meat ', '1 kg'),
(72, 'Ground beef, regular', 13.23, 'Meat ', '1 kg'),
(73, 'Pork chops', 13.26, 'Meat ', '1 kg'),
(74, 'Chicken', 7.82, 'Meat ', '1 kg'),
(75, 'Bacon', 6.86, 'Meat ', '500 g'),
(76, 'Wieners', 4.25, 'Dairy', '450 g'),
(77, 'Canned sockeye salmon', 4.47, 'Dairy', '413  g'),
(78, 'Homogenized milk', 2.47, 'Dairy', '1 l'),
(79, 'Partly skimmed milk', 2.33, 'Dairy', '1 l'),
(80, 'Butter', 4.67, 'Dairy', '454 g'),
(81, 'Processed cheese food slices', 3, 'Dairy', '250 g'),
(82, 'Processed cheese food slices', 1.86, 'Dairy', '385 ml'),
(83, 'Eggs', 3.33, 'Dairy', '1 dz'),
(84, 'Bread', 2.99, 'Bakery and confectionery', '675 g'),
(85, 'Milk', 2.5, 'Dairy', '1 l'),
(86, 'Сheese ', 5, 'Dairy', '1 kg'),
(87, 'Round steak', 19.32, 'Meat ', '1 kg'),
(88, 'Sirloin steak', 24.74, 'Meat ', '1 kg'),
(89, 'Milk', 2.5, 'Dairy', '1 l'),
(90, 'Сheese ', 5, 'Dairy', '1 kg'),
(91, 'Round steak', 19.32, 'Meat ', '1 kg'),
(92, 'Sirloin steak', 24.74, 'Meat ', '1 kg'),
(93, 'Prime rib roast', 30.76, 'Meat ', '1 kg'),
(94, 'Blade roast', 16.65, 'Meat ', '1 kg'),
(95, 'Stewing beef', 17.27, 'Meat ', '1 kg'),
(96, 'Ground beef, regular', 13.23, 'Meat ', '1 kg'),
(97, 'Pork chops', 13.26, 'Meat ', '1 kg'),
(98, 'Chicken', 7.82, 'Meat ', '1 kg'),
(99, 'Bacon', 6.86, 'Meat ', '500 g'),
(100, 'Wieners', 4.25, 'Dairy', '450 g'),
(101, 'Canned sockeye salmon', 4.47, 'Dairy', '413  g'),
(102, 'Homogenized milk', 2.47, 'Dairy', '1 l'),
(103, 'Partly skimmed milk', 2.33, 'Dairy', '1 l'),
(104, 'Butter', 4.67, 'Dairy', '454 g'),
(105, 'Processed cheese food slices', 3, 'Dairy', '250 g'),
(106, 'Processed cheese food slices', 1.86, 'Dairy', '385 ml'),
(107, 'Eggs', 3.33, 'Dairy', '1 dz'),
(108, 'Bread', 2.99, 'Bakery and confectionery', '675 g'),
(109, 'Milk', 2.5, 'Dairy', '1 l'),
(110, 'Сheese ', 5, 'Dairy', '1 kg'),
(111, 'Round steak', 19.32, 'Meat ', '1 kg'),
(112, 'Sirloin steak', 24.74, 'Meat ', '1 kg'),
(113, 'Prime rib roast', 30.76, 'Meat ', '1 kg'),
(114, 'Soda crackers', 2.92, 'Grocery', '450 g'),
(115, 'Macaroni', 1.64, 'Grocery', '500 g'),
(116, 'Flour', 4.95, 'Grocery', '2.5 kg'),
(117, 'Corn flakes', 5.03, 'Grocery', '675 g'),
(118, 'Apples', 4.13, 'Fruits and Vegetables', '1 kg'),
(119, 'Bananas', 1.65, 'Fruits and Vegetables', '1 kg'),
(120, 'Grapefruits', 3.61, 'Fruits and Vegetables', '1 kg'),
(121, 'Oranges', 3.56, 'Fruits and Vegetables', '1 kg'),
(122, 'Apple juice, canned', 2.17, 'Drinks', '1.36 l'),
(123, 'Orange juice, tetra-brick', 4, 'Drinks', '1 l'),
(124, 'Carrots', 1.7, 'Fruits and Vegetables', '1 kg'),
(125, 'Celery', 2.24, 'Fruits and Vegetables', '1 kg'),
(126, 'Mushrooms', 8.23, 'Fruits and Vegetables', '1 kg'),
(127, 'Onions', 1.34, 'Fruits and Vegetables', '1 kg'),
(128, 'Potatoes', 5.43, 'Fruits and Vegetables', '4.54 kg'),
(129, 'French fried potatoes, frozen', 2.59, 'Grocery', '1 kg'),
(130, 'Baked beans, canned', 1.99, 'Canned food', '398 ml'),
(131, 'Tomatoes, canned', 1.09, 'Canned food', '796 ml'),
(132, 'Tomato juice, canned', 2.4, 'Drinks', '1.36 l	'),
(133, 'Ketchup', 3.6, 'Canned food', '1 l'),
(134, 'Sugar, white', 2.35, 'Grocery', '2 kg'),
(135, 'Coffee, roasted', 6.45, 'Drinks', '300 g'),
(136, 'Coffee, instant', 7.64, 'Drinks', '200 g'),
(137, 'Tea (bags)', 4.72, 'Drinks', '72'),
(138, 'Cooking or salad oil', 4.81, 'Canned food', '1 l'),
(139, 'Soup, canned', 1.23, 'Canned food', '284 ml'),
(140, 'Baby food', 0.39, 'Baby', '128 ml'),
(141, 'Peanut butter', 3.49, NULL, '500 g'),
(142, 'Fruit flavoured crystals', 1.29, 'Drinks', '2.25 l'),
(143, 'Soft drinks, cola type', 1.5, 'Drinks', '2 l'),
(144, 'Soft drinks, lemon-lime type', 1.73, 'Drinks', '2 l'),
(145, 'Paper towels (rolls)', 2.44, 'Hygiene', '2 '),
(146, 'Facial tissue', 2.15, 'Hygiene', '200'),
(147, 'Bathroom tissue (rolls)', 2.25, 'Hygiene', '4'),
(148, 'Shampoo', 3.27, 'Hygiene', '300 ml'),
(149, 'Deodorant', 4.4, 'Hygiene', '60 g'),
(150, 'Toothpaste', 2.65, 'Hygiene', '100 ml'),
(151, 'Cigarettes', 97.75, 'Drinks', '200	'),
(152, 'Hershey''s Cinnamon Baking Chips', 2.38, 'Baking Chips', '283 g');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
