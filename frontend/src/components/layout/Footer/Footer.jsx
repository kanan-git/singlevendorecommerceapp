import { useState, useEffect } from "react";
import "./Footer_features.js";
import "./Footer_styles.css";

function Footer() {
    return (
        <footer className="footer">
1. Brand Section

Top part of footer.

Contains:

Logo / Store name
Short description of the store

Purpose:

Reinforce brand identity
Give a quick idea of what the store is about
2. Quick Links

Navigation shortcut section.

Contains:

Home
Explore
About
Contact
Wishlist
Cart

Purpose:

Help users navigate without scrolling back up
3. Customer Service / Help

Support-related links.

Contains:

Shipping info
Returns & refunds
FAQ
Contact support

Purpose:

Reduce friction for common questions
4. Account Links

User-related section.

Contains:

Login
Register
My account
Order history

Purpose:

Quick access to user-specific pages
5. Contact Information

Business contact section.

Contains:

Email address
Phone number
Physical address (optional)

Purpose:

Provide direct communication channels
6. Social Media Links

External connection section.

Contains:

Instagram
Facebook
Twitter/X
LinkedIn (optional)

Purpose:

Extend brand presence outside the site
7. Newsletter Subscription (Optional)

Engagement section.

Contains:

Email input
Subscribe button

Purpose:

Collect emails for updates and promotions
8. Legal / Copyright

Bottom-most section.

Contains:

Copyright text
Privacy policy
Terms of service

Purpose:

Legal compliance and professionalism
        </footer>
    );
};

export default Footer;
