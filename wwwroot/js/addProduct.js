const button = document.querySelector('#form-button');

async function getCategories() {
    const categories = await fetch('/Category/getcategories');
    const selectCategory = document.querySelector('#select-category');
    const categoriesList = await categories.json();

    categoriesList.value.forEach((cat) => {
        const option = document.createElement('option');

        option.innerHTML = cat.categoryName;

        selectCategory.appendChild(option);
    });
}

async function submitProduct(event) {
    event.preventDefault();

    const productName = document.querySelector('#product-name').value;
    const productPrice = document.querySelector('#product-price').value;
    const productCategory = document.querySelector('#select-category').value;

    if (productName.length === 0 || productPrice === 0 || productCategory.length === 0) {
        return;
    }

    const data = {
        productName, productPrice, productCategory
    };

    console.log(data);
}

getCategories();

button.addEventListener('click', submitProduct);
