import { useState, useEffect } from "react";
import "./Header_features.js";
import "./Header_styles.css";

function Header() {
    return (
        <header className="header">
1. Logo / Brand

Primary identity section.

Contains:

Store logo
Store name

Purpose:

Brand recognition
Quick navigation to Home page
2. Navigation Menu

Main navigation section.

Contains:

Home
Explore
About
Contact

Provides access to the site's primary pages.

3. Search

Quick product discovery section.

Contains:

Search input
Search icon/button

Allows users to find products from anywhere.

4. Wishlist Access

User utility section.

Contains:

Wishlist icon
Saved items count (optional)

Provides quick access to saved products.

5. Cart Access

Shopping section.

Contains:

Cart icon
Cart item count
Optional cart total

One of the most frequently used header elements.

6. Authentication Area

Account section.

When guest:

Login
Register

When authenticated:

User avatar/name
Account menu
Logout

Provides account-related actions.

7. Mobile Navigation

Responsive section.

Contains:

Hamburger menu
Mobile navigation drawer

Required for smaller screens.

8. Announcement Bar (Optional)

Topmost information section.

Examples:

Free shipping offers
Seasonal discounts
Store announcements

Useful but not required.
        </header>
    );
};

export default Header;
