import React, { useState } from "react";
import { Routes, Route, Navigate } from "react-router-dom";
import Header from "./components/layout/Header/Header.jsx";
import Footer from "./components/layout/Footer/Footer.jsx";
import Brands from "./pages/admin/Brands/Brands.jsx";
import Categories from "./pages/admin/Categories/Categories.jsx";
import Dashboard from "./pages/admin/Dashboard/Dashboard.jsx";
import ProductCreate from "./pages/admin/ProductCreate/ProductCreate.jsx";
import ProductEdit from "./pages/admin/ProductEdit/ProductEdit.jsx";
import Products from "./pages/admin/Products/Products.jsx";
import UserOrders from "./pages/admin/UserOrders/UserOrders.jsx";
import Login from "./pages/auth/Login/Login.jsx";
import Recovery from "./pages/auth/Recovery/Recovery.jsx";
import Register from "./pages/auth/Register/Register.jsx";
import OrderDetails from "./pages/user/OrderDetails/OrderDetails.jsx";
import Orders from "./pages/user/Orders/Orders.jsx";
import Profile from "./pages/user/Profile/Profile.jsx";
import About from "./pages/info/About/About.jsx";
import Contact from "./pages/info/Contact/Contact.jsx";
import Error from "./pages/info/Error/Error.jsx";
import Cart from "./pages/core/Cart/Cart.jsx";
import Checkout from "./pages/core/Checkout/Checkout.jsx";
import Details from "./pages/core/Details/Details.jsx";
import Explore from "./pages/core/Explore/Explore.jsx";
import Wishlist from "./pages/core/Wishlist/Wishlist.jsx";
import Home from "./pages/core/Home/Home.jsx";
import "./assets/css/variables.css";
import "./assets/css/animations.css";
import "./assets/css/global.css";

function App() {
	return (
		<>
			<Header />

			<Routes>
				{/* ADMIN ROUTES */}
				<Route path="/admin/brands" element={<Brands />} />
				<Route path="/admin/categories" element={<Categories />} />
				<Route path="/admin/dashboard" element={<Dashboard />} />
				<Route path="/admin/products/create" element={<ProductCreate />} />
				<Route path="/admin/products/edit" element={<ProductEdit />} />
				<Route path="/admin/products" element={<Products />} />
				<Route path="/admin/orders" element={<UserOrders />} />
				
				{/* AUTH ROUTES */}
				<Route path="/auth/login" element={<Login />} />
				<Route path="/auth/recovery" element={<Recovery />} />
				<Route path="/auth/register" element={<Register />} />

				{/* USER ROUTES */}
				<Route path="/user/orderdetails" element={<OrderDetails />} />
				<Route path="/user/orders" element={<Orders />} />
				<Route path="/user/profile" element={<Profile />} />

				{/* INFO ROUTES */}
				<Route path="/about" element={<About />} />
				<Route path="/contact" element={<Contact />} />
				<Route path="/error" element={<Error />} />
				
				{/* CORE ROUTES */}
				<Route path="/cart" element={<Cart />} />
				<Route path="/checkout" element={<Checkout />} />
				<Route path="/details" element={<Details />} />
				<Route path="/explore" element={<Explore />} />
				<Route path="/wishlist" element={<Wishlist />} />
				<Route path="/" element={<Home />} />

				{/* REDIRECTIONS */}
				<Route path="*" element={<Navigate to={"/error?code=404"} />} />
			</Routes>

			<Footer />
		</>
	);
};

export default App;
