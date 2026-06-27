import { useState } from "react";
import { Link } from "react-router-dom";
import icons from "../../../assets/utils/constants/bootstrapIcons.js";
import "./ProductCard_features.js";
import "./ProductCard_styles.css";

function ProductCard( props ) {
    const {id, title, imgPath, price, discount, ratingCount, ratingPoint, stock} = props.data;

    const [imgIndex, setImgIndex] = useState(0);

    function setStars(point, cardid) {
        const stars = [];
        for(let i=0; i<5; i++) {
            if(point-1 >= 0) {
                stars.push(<i className={icons.product.ratingstarSolid} key={`pc_${cardid}_star_${i}`}></i>);
                point = point-1;
                continue;
            };
            if(stars.length < 5 && point > 0) {
                stars.push(<i className={icons.product.ratingstarHalf} key={`pc_${cardid}_star_${i}`}></i>);
                point = 0;
                continue;
            };
            if(stars.length != 5) {
                stars.push(<i className={icons.product.ratingstarEmpty} key={`pc_${cardid}_star_${i}`}></i>);
                continue;
            };
        };
        return stars;
    };

    function optimizeCount(count) {
        const levels = [9, 6, 3];
        const guide = {9: "B", 6: "M", 3: "k"};
        for(let i=0; i<levels.length; i++) {
            if(count > 10**levels[i]) {
                return Math.round(count/(10**levels[i])).toString() + guide[levels[i]];
            };
        };
        return count;
    };

    function collapseLongTitle(string="") {
        const limit = 32;
        if(string.length > limit) {
            return string.slice(0, limit) + "...";
        };
        return string;
    };

    function showOtherImages(e) {
        // use caching here
        const imageContainer = document.querySelector(`#productcard_${props.serial}_${id} > .productcard__image`);
        const width = imageContainer.getBoundingClientRect().width;
        const mouseX = e.nativeEvent.layerX;
        const verticalPercentage = Math.round((mouseX / width) * 100);        
        const finalIndex = imgPath.length-1;
        const activeIndex = Math.round(finalIndex * verticalPercentage / 100);
        setImgIndex(activeIndex);

        // let cards = imageContainer.children;
        const cards = document.querySelectorAll(`#productcard_${props.serial}_${id} > .productcard__image > .productcard__image-content`);
        const radios = document.querySelectorAll(`#productcard_${props.serial}_${id} .productcard__image-radios > div`);
        for(let i=0; i<cards.length; i++) {
            if(i == activeIndex) {
                cards[i].style.zIndex = `2`;
                radios[i].style.backgroundColor = `var(--color-primary)`;
            } else {
                cards[i].style.zIndex = `1`;
                radios[i].style.backgroundColor = `var(--color-on-primary)`;
            };
        };
    };

    function showFirstImage() {
        setImgIndex(0);
        const cards = document.querySelectorAll(`#productcard_${props.serial}_${id} > .productcard__image > .productcard__image-content`);
        const radios = document.querySelectorAll(`#productcard_${props.serial}_${id} .productcard__image-radios > div`);
        for(let i=0; i<cards.length; i++) {
            if(i == 0) {
                cards[i].style.zIndex = `2`;
                radios[i].style.backgroundColor = `var(--color-primary)`;
            } else {
                cards[i].style.zIndex = `1`;
                radios[i].style.backgroundColor = `var(--color-on-primary)`;
            };
        };
    };

    return (
        <Link to={"/details?id="+id} className="productcard" id={`productcard_${props.serial}_${id}`} onMouseEnter={() => {
            // 
        }} onMouseLeave={() => {
            // 
        }}>
            <div className="productcard__image" onMouseMove={(event) => showOtherImages(event)} onMouseLeave={() => {
                showFirstImage();
                document.querySelector(`#productcard_${props.serial}_${id} .productcard__image-radios`).style.display = `none`;
            }} onMouseEnter={() => {
                document.querySelector(`#productcard_${props.serial}_${id} .productcard__image-radios`).style.display = `flex`;
            }}>
                {imgPath.length > 0 && imgPath.map((url, index) => {
                    return (<img key={index} className="productcard__image-content" src={`/images/products/${url}`} alt={`image_${index+1}`} style={index==0 ? {zIndex:"2"} : {zIndex:"1"}} />);
                })}
                <div className="productcard__image-radios">
                    {imgPath.length > 0 && imgPath.map((url, index) => {
                        return (<div key={index} style={index==0 ? {backgroundColor:"var(--color-primary)"} : {backgroundColor:"var(--color-on-primary)"}}></div>);
                    })}
                </div>
                <div className="productcard__image-info">
                    <span className="productcard__image-group">
                        {discount>0 && <span className="productcard__image-discount">-{discount}%</span>}
                        <span className="productcard__image-stock" style={stock!=0 ? {border:"1px solid var(--color-stock-in)", color:"var(--color-stock-in)"} : {border:"1px solid var(--color-stock-out)", color:"var(--color-stock-out)"}}>{stock==0 ? "Out of Stock" : "In Stock"}</span>
                    </span>
                    <span className="productcard__image-imgnav">{imgIndex+1}/{imgPath.length}</span>
                </div>
            </div>
            {discount > 0 ? (
                <div className="productcard__price">
                    <del>${price%1==0 ? price.toString()+".00" : price}</del>
                    <strong>${price%1==0 ? (price-(price*discount/100)).toString()+".00" : price-(price*discount/100)}</strong>
                    {/* price actually shouldn't calculated here, get also discounted price from backend */}
                </div>
            ) : (
                <strong>${price%1==0 ? price.toString()+".00" : price}</strong>
            )}
            <div className="productcard__title">
                <span>{collapseLongTitle(title)}</span>
            </div>
            <div className="productcard__rating">
                <span className="productcard__rating-count">{ratingPoint%1==0 ?ratingPoint.toString()+".0" :ratingPoint}</span>
                <span className="productcard__rating-stars">{setStars(ratingPoint, id)}</span>
                <span className="productcard__rating-reviews">({optimizeCount(ratingCount)})</span>
            </div>

            
            <div className="productcard__rating-buttons" onClick={(e) => {
                e.preventDefault();
            }}>
                <button>
                    <i className={icons.product.wishlistAdd}></i>
                    <span>Add to Wishlist</span>
                </button>
                <button disabled={stock>0 ? false : true}>
                    <i className={icons.pages.core.Cart}></i>
                    <span>Add to Cart</span>
                </button>
            </div>
        </Link>
    );
};

export default ProductCard;
