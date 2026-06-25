import { useState, useEffect } from "react";
import { Link } from "react-router-dom";
import icons from "../../../assets/utils/constants/bootstrapIcons.js";
import Logo from "../../../assets/images/logo/logo.png";
import roles from "../../../assets/utils/tempFakeDatabase/roles.js";
import "./Footer_features.js";
import "./Footer_styles.css";

function Footer() {
    const [token, setToken] = useState({role: roles.guest});
    const [subEmail, setSubEmail] = useState("");

    return (
        <footer className="footer">
            <section className="footer__main">
                <div className="footer__main--column">
                    <h3>Contact</h3>
                    <ul>
                        <li>
                            <i className={icons.info.contactAddress}></i>
                            <span>Address Line 1: Lorem Ipsum 1, Baku, Azerbaijan</span>
                        </li>
                        <li>
                            <i className={icons.info.contactAddress}></i>
                            <span>Address Line 2: Dolor Sit 2, Baku, Azerbaijan</span>
                        </li>
                        <li>
                            <i className={icons.info.contactPhone}></i>
                            <span>Telephone Number: (012) 123-45-67</span>
                        </li>
                        <li>
                            <i className={icons.info.contactPhone}></i>
                            <span>WhatsApp Contact: +994 (050) 123 45 67</span>
                        </li>
                        <li>
                            <i className={icons.info.contactEmail}></i>
                            <span>Email Address: untitled@gmail.com</span>
                        </li>
                    </ul>
                    <form onSubmit={() => {}}>
                        <input type="text" value={subEmail} onChange={(e) => setSubEmail(e)} />
                        <button onClick={() => {}}>Subscribe</button>
                    </form>
                </div>
                <div className="footer__main--column">
                    <h3>Categories</h3>
                    <ul>
                        <li>
                            <Link to="/explore?cat=category1">
                                category1
                            </Link>
                        </li>
                        <li>
                            <Link to="/explore?cat=category2">
                                category2
                            </Link>
                        </li>
                        <li>
                            <Link to="/explore?cat=category3">
                                category3
                            </Link>
                        </li>
                        <li>
                            <Link to="/explore?cat=category4">
                                category4
                            </Link>
                        </li>
                        <li>
                            <Link to="/explore?cat=category5">
                                category5
                            </Link>
                        </li>
                        <li>
                            <Link to="/explore?cat=category6">
                                category6
                            </Link>
                        </li>
                    </ul>
                </div>
                <div className="footer__main--column">
                    {token.role==roles.guest && <>
                        <h3>Guest</h3>
                        <ul>
                            <li>
                                <Link to="/">
                                    Wishlist
                                </Link>
                            </li>
                            <li>
                                <Link to="/">
                                    Cart
                                </Link>
                            </li>
                            <li>
                                <Link to="/">
                                    About
                                </Link>
                            </li>
                            <li>
                                <Link to="/">
                                    Contact
                                </Link>
                            </li>
                        </ul>
                    </>}
                    {token.role==roles.user && <>
                        <h3>You</h3>
                        <ul>
                            <li>
                                <Link to="/">
                                    Wishlist
                                </Link>
                            </li>
                            <li>
                                <Link to="/">
                                    Cart
                                </Link>
                            </li>
                            <li>
                                <Link to="/">
                                    About
                                </Link>
                            </li>
                            <li>
                                <Link to="/">
                                    Contact
                                </Link>
                            </li>
                            <li>
                                <Link to="/">
                                    Orders
                                </Link>
                            </li>
                            <li>
                                <Link to="/">
                                    Profile
                                </Link>
                            </li>
                        </ul>
                    </>}
                    {token.role==roles.admin && <>
                        <h3>Admin</h3>
                        <ul>
                            <li>
                                <Link to="/">
                                    Dashboard
                                </Link>
                            </li>
                            <li>
                                <Link to="/">
                                    Products
                                </Link>
                            </li>
                            <li>
                                <Link to="/">
                                    Brands
                                </Link>
                            </li>
                            <li>
                                <Link to="/">
                                    Categories
                                </Link>
                            </li>
                            <li>
                                <Link to="/">
                                    Orders
                                </Link>
                            </li>
                        </ul>
                    </>}
                </div>
                <div className="footer__main--column">
                    <div>
                        <img src={Logo} alt="logo" />
                    </div>
                    <p>
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit. Fuga praesentium sequi nostrum qui soluta distinctio fugiat iure reiciendis laborum dignissimos!
                    </p>
                    <div>
                        <Link to="https://instagram.com">
                            <i className={icons.info.socialInstagram}></i>
                        </Link>
                        <Link to="https://tiktok.com">
                            <i className={icons.info.socialTiktok}></i>
                        </Link>
                        <Link to="https://x.com">
                            <i className={icons.info.socialX}></i>
                        </Link>
                        <Link to="https://youtube.com">
                            <i className={icons.info.socialYouTube}></i>
                        </Link>
                    </div>
                </div>
            </section>
            <section className="footer__bottom">
                <span>
                    Copyrights 2026 © All Rights Reserved.
                </span>
                <span>
                    <Link to="/">Terms</Link>
                    <Link to="/">Privacy</Link>
                </span>
            </section>
        </footer>
    );
};

export default Footer;
