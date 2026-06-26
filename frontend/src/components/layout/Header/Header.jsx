import { useState, useEffect } from "react";
import { Link } from "react-router-dom";
import icons from "../../../assets/utils/constants/bootstrapIcons.js";
import Logo from "../../../assets/images/logo/logo.png";
import roles from "../../../assets/utils/tempFakeDatabase/roles.js";
import "./Header_features.js";
import "./Header_styles.css";

function Header() {
    const [token, setToken] = useState({role: roles.guest});
    const [query, setQuery] = useState("");

    return (
        <header className="header">
            <section className="header__container">
                {/* <button>
                    mobile button
                </button> */}

                <Link to="/" className="header__container--logo">
                    <img src={Logo} alt="logo" />
                </Link>

                <nav className="header__container--navbar">
                    <form onSubmit={(e) => {
                        // e.preventDefault();
                    }}>
                        <input type="search" value={query} onChange={e => setQuery(e.target.value)} />
                        <button>
                            <i className={icons.misc.search}></i>
                        </button>
                    </form>
                    <ul>
                        <li>
                            <i className={icons.pages.core.Home}></i>
                            <Link to="/">Home</Link>
                        </li>
                        <li>
                            <i className={icons.pages.core.Explore}></i>
                            <Link to="/explore">Products</Link>
                            <i className={icons.misc.hasDropdown}></i>
                        </li>
                        <li>
                            <i className={icons.pages.info.About}></i>
                            <Link to="/about">About</Link>
                        </li>
                        <li>
                            <i className={icons.pages.info.Contact}></i>
                            <Link to="/contact">Contact</Link>
                        </li>
                        {token.role==roles.user && <li>
                            <i className={icons.pages.user.Profile}></i>
                            <Link to="/user/profile">Profile</Link>
                        </li>}
                        {token.role==roles.admin && (<>
                            <li>
                                <i className={icons.pages.admin.Dashboard}></i>
                                <Link to="/admin/dashboard">Dashboard</Link>
                            </li>
                            <li>
                                <i className={icons.pages.admin.Products}></i>
                                <Link to="/admin/products">Products</Link>
                            </li>
                            <li>
                                <i className={icons.pages.admin.Brands}></i>
                                <Link to="/admin/brands">Brands</Link>
                            </li>
                            <li>
                                <i className={icons.pages.admin.Categories}></i>
                                <Link to="/admin/categories">Categories</Link>
                            </li>
                            <li>
                                <i className={icons.pages.admin.UserOrders}></i>
                                <Link to="/admin/orders">Orders</Link>
                            </li>
                        </>)}
                    </ul>
                </nav>

                <div className="header__container--cta">
                    {token && token.role == roles.guest && <>
                        <div>
                            <button>
                                <i className={icons.pages.core.Wishlist}></i>
                                <div>3</div>
                            </button>
                            <button>
                                <i className={icons.pages.core.Cart}></i>
                                <div>15</div>
                            </button>
                        </div>
                        <button>
                            <span>Sign In</span>
                        </button>
                    </>}
                    {token && token.role == roles.user && <>
                        <div>
                            <button>
                                <i className={icons.pages.core.Wishlist}></i>
                                <div>3</div>
                            </button>
                            <button>
                                <i className={icons.pages.core.Cart}></i>
                                <div>15</div>
                            </button>
                        </div>
                        <span>
                            <span>
                                <img src="/" alt="profile" />
                            </span>
                            <i className={icons.misc.hasDropdown}></i>

                            <ul>
                                <li>
                                    <Link to="/user/orders">My Orders</Link>
                                </li>
                                <li>
                                    <span>Logout</span>
                                </li>
                            </ul>
                        </span>
                    </>}
                    {token && token.role == roles.admin && <>
                        <div>
                            <button>
                                <i className={icons.pages.core.Wishlist}></i>
                                <div>3</div>
                            </button>
                            <button>
                                <i className={icons.pages.core.Cart}></i>
                                <div>15</div>
                            </button>
                        </div>
                        <span>
                            <span>
                                <img src="/" alt="profile" />
                            </span>
                            <i className={icons.misc.hasDropdown}></i>

                            <ul>
                                <li>
                                    <Link to="/admin/dashboard">Admin Panel</Link>
                                </li>
                                <li>
                                    <span>Logout</span>
                                </li>
                            </ul>
                        </span>
                    </>}
                </div>
            </section>
        </header>
    );
};

export default Header;
