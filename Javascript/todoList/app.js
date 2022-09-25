const listElement = document.getElementsByTagName("li")
const addForm = document.querySelector(".add");
const search = document.querySelector(".search");
const ul = document.querySelector(".todos");
const compleTedTask = document.querySelector("completedTask")

for (li of listElement) {
    li.style.color = "white";
}

const generateTasks = task => {
    const html = `
    <li class="list-group-item d-flex justify-content-between align-items-center text-white">
    <span>${task}</span>
    <i class="far fa-trash-alt delete"></i>
</li>`;
    ul.innerHTML += html;
}


let removeTask = 0;
// This code ask the user to comfirm before deleting a task
ul.addEventListener('click', e => {
    const confirmation = prompt("Type 'y' to comfirm or 'n' to deny ").toLowerCase();
    if (confirmation === 'y') {
        //remove the li
        e.target.remove();
        removeTask++
        const para = document.createElement("p");
        para.textContent += "You have completed " + removeTask + " tasks "
        console.log(para)

    }

})

// This part of the code let the user type something  and append it to an ul element
addForm.addEventListener('submit', e => {
    e.preventDefault(); // Prevent the form from refreshing
    task = addForm.add.value.trim();
    if (task === "") {
        alert("Todo cannot be empty")
    } else {
        generateTasks(task)
    }
})

// this function filter a searched term

const SearchTerm = term => {

    Array.from(ul.children)
        .filter(task => !task.textContent.includes(term))
        .forEach(task => task.classList.add("filtered"))
    Array.from(ul.children)
        .filter(task => task.textContent.includes(term))
        .forEach(task => task.classList.remove("filtered"))
}

// This part of the code allow a user to search for a specific todo
search.addEventListener("keyup", e => {
    e.preventDefault();
    term = search.input_term.value;
    SearchTerm(term);
})


