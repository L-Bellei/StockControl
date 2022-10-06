async function getTableData() {
    const tbody = document.querySelector(".table-body");

    const data = await fetch('/Category/GetCategories');

    const response = await data.json();

    response.value.forEach((cat) => {
        const content = `<td>${cat.categoryName}</td>
                         <td>${cat.description}</td>
                         <td>
                            <button class="table-button edit-button" id="edit-button">EDIT</button>
                            <button class="table-button delete-button" id="delete-button">DELETE</button>
                        </td>`;
        const tr = document.createElement('tr');

        tr.id = cat.id;

        tr.innerHTML = content;
        tbody.appendChild(tr);
    });

    const tableBody = document.querySelector('.table-body');
    const trList = tableBody.querySelectorAll('tr');


    trList.forEach(trItem => {
        const editButton = trItem.querySelector('#edit-button');
        const deleteButton = trItem.querySelector('#delete-button');

        editButton.addEventListener('click', (e) => editCategory(e));
        deleteButton.addEventListener('click', (e) => deleteCategory(e));
    });
}

async function editCategory(event) {
    event.preventDefault();

    const tr = event.target;
    const id = tr.parentElement.parentElement;

    console.log(id)
}

async function deleteCategory() {
    event.preventDefault();

    const tr = event.target;
    const id = tr.parentElement.parentElement;

    console.log(id)
}

getTableData();