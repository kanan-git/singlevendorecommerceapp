import { useState, useEffect } from "react";
import "./Checkout_api.js";
import "./Checkout_features.js";
import "./Checkout_styles.css";

function Checkout() {
    return (
        <main className="checkout">
1. Checkout Header

Top section.

Contains:

Page title ("Checkout")
Optional checkout progress indicator
Optional breadcrumb

Purpose:

Show users they are in the final purchase stage.
2. Customer Information

Customer details section.

Contains:

Full name
Email
Phone number

Used for communication and order confirmation.

3. Shipping Information

Delivery details section.

Contains:

Country
City
Address
Postal/ZIP code
Additional notes (optional)

Required for order fulfillment.

4. Shipping Method

Delivery selection section.

Contains:

Available shipping options
Estimated delivery information
Shipping cost

Allows users to choose how they want their order delivered.

5. Payment Method

Payment selection section.

Contains:

Payment options
Stripe payment area
Billing information (if needed)

This is one of the most important sections on the page.

6. Order Review

Final review before purchase.

Contains:

Ordered products
Quantities
Prices
Shipping information summary

Helps users verify everything before placing the order.

7. Order Summary

Cost breakdown section.

Contains:

Subtotal
Shipping cost
Tax
Discounts
Grand Total

Should remain visible throughout checkout if possible.

8. Terms & Confirmation

Final confirmation area.

Contains:

Terms acceptance checkbox
Privacy acknowledgment (optional)

Common practice before order submission.

9. Place Order CTA

Primary action section.

Contains:

Place Order button

This should be the most prominent action on the page.

10. Checkout Success State

Shown after successful purchase.

Contains:

Success message
Order number
Order summary
Continue Shopping button

Provides closure and confirmation.
        </main>
    );
};

export default Checkout;
