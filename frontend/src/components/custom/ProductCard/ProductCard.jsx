import { useEffect } from "react";
import icons from "../../../assets/utils/constants/bootstrapIcons.js";
import "./ProductCard_features.js";
import "./ProductCard_styles.css";

function ProductCard( props ) {
    const {id, title, imgPath, price, discount, ratingCount, ratingPoint} = props.data;

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

    function collapseLongTitle(string) {};

    function showOtherImages(e) {
        const imageContainer = document.querySelector(`#productcard_${props.serial}_${id} > .productcard__image`);
        const width = imageContainer.getBoundingClientRect().width;
        const mouseX = e.nativeEvent.layerX;
        const verticalPercentage = Math.round((mouseX / width) * 100);        
        const finalIndex = imgPath.length-1;
        const activeIndex = Math.round(finalIndex * verticalPercentage / 100);

        console.log(activeIndex);

        let cards = imageContainer.children;
        console.log(cards, cards.length);

        cards.forEach((card, index) => {
            if(index == activeIndex) {
                card.style.zIndex = 2;
            } else {
                card.style.zIndex = 1;
            };
        });

        // 1. somehow need to be able to select image by activeIndex so can alter zIndex or left position
        // 2. onMouseEnter, need to button to appear for wishlist and add to cart, infos for is discounted, stock, new
    };
    function showFirstImage() {};

    return (
        <div className="productcard" id={`productcard_${props.serial}_${id}`}>
            <div className="productcard__image" onMouseMove={(event) => showOtherImages(event)} onMouseLeave={showFirstImage}>
                {imgPath.length > 0 && imgPath.map((url, index) => {
                    return (<img key={index} src={`/images/products/${url}`} alt={`image_${index+1}`} />);
                })}
                {/* <div className="productcard__image-radios">
                    {imgPath.length > 0 && imgPath.map((url, index) => {
                        return (<div key={index}></div>);
                    })}
                </div> */}
            </div>
            {discount > 0 ? (
                <div className="productcard__price">
                    <del>${price}</del>
                    <strong>${price - (price * discount / 100)}</strong>
                </div>
            ) : (
                <strong>${price}</strong>
            )}
            <div className="productcard__title">
                <span>{title}</span>
            </div>
            <div className="productcard__rating">
                <span className="productcard__rating-count">{ratingPoint}</span>
                <span className="productcard__rating-stars">{setStars(ratingPoint, id)}</span>
                <span className="productcard__rating-reviews">({optimizeCount(ratingCount)})</span>
            </div>
        </div>
    );
};

export default ProductCard;
