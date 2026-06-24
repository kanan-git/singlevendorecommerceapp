import { useState, useEffect } from "react";
import "./Contact_api.js";
import "./Contact_features.js";
import "./Contact_styles.css";

function Contact() {
    return (
        <main className="contact">
1. Contact Header

Top section.

Contains:

Page title ("Contact Us")
Short introduction message

Purpose:

Tell users how they can reach your business.
2. Contact Information

Main business contact details.

Contains:

Email address
Phone number
Business address
Working hours

Allows users to contact you directly without using the form.

3. Contact Form

Primary interaction section.

Contains:

Name
Email
Subject
Message
Send button

This is usually the core feature of the page.

4. Support Categories (Optional)

Helps users identify their request type.

Examples:

General Inquiry
Order Support
Returns & Refunds
Partnership
Technical Issue

Useful if you want a more professional feel.

5. FAQ Preview (Optional)

Common questions section.

Examples:

Shipping questions
Return policy questions
Payment questions

Can reduce unnecessary support requests.

6. Location / Map (Optional)

Business location section.

Contains:

Store address
Embedded map

Useful if the business has a physical presence.

7. Social Links

Additional communication channels.

Examples:

Instagram
Facebook
LinkedIn
X/Twitter

Provides alternative ways to connect.

8. Success Message State

Shown after form submission.

Contains:

Confirmation message
Expected response timeframe
Return/Home button

Lets users know their message was received.
        </main>
    );
};

export default Contact;
