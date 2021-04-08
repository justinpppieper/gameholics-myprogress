const cardContainer = document.querySelectorAll('.card-container')
const card = document.querySelectorAll('.card')
const avatar = document.querySelectorAll('.avatar img')
const ul = document.getElementById("ul");
const toggleIcon = document.getElementById("toggle-icon")

for (let i = 0; i < card.length; i++) {
    card[i].addEventListener('mouseenter', e => {
        avatar[i].style.transform = "rotateZ(30deg)"

    })
}

for (let i = 0; i < card.length; i++) {
    card[i].addEventListener('mouseleave', e => {
        avatar[i].style.transform = 'rotateZ(0deg)'
    })
}

var swiper = new Swiper('.swiper-container', {
    effect: 'coverflow',
    grabCursor: true,
    centeredSlides: true,
    slidesPerView: 'auto',
    coverflowEffect: {
        rotate: 0,
        stretch: 0,
        depth: 0,
        modifier: 1,
        slideShadows: true,
    },
    loop: true,
    pagination: {
        el: '.swiper-pagination',
    },
});

function toggleNavList() {
    if (ul.className === "nav-list") {
        ul.className = "nav-list show-nav-list"
    } else {
        ul.className = "nav-list"
    }
}

document.addEventListener("click", function(e) {
    if (e.target !== toggleIcon) {
        ul.className = "nav-list"
    }
})