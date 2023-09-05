document.addEventListener("DOMContentLoaded", () => {
    const movieList = document.getElementById("movieList");
    const createmovieform = document.getElementById("createmovieform");
    const updatemovieform = document.getElementById("updatemovieform");
    const deletemovieform = document.getElementById("deletemovieform");

    function displayMovie() {
        fetch("http://localhost:5285/api/Movies")
            .then(response => {
                if (!response.ok) {
                    throw new Error(`HTTP error! Status :${response.status}`);
                }
                return response.json();
            })
            .then(movies => {
                movieList.innerHTML = "";
                movies.forEach(movie => {
                    const listitem = document.createElement("li");
                    listitem.textContent = `ID:${movie.Id},Title:${movie.Title},Director :${movie.Director},Hero :${movie.Hero},Heroine :${movie.Heroine}`;
                    movieList.appendChild(listitem);
                });
            })
            .catch(error => {
                console.error("Fetch Error :", error);
                movieList.innerHTML = "Error Fetching movies."
            });
    }








    createmovieform.addEventListener("submit", (e) => {
        e.preventDefault();
        const title = document.getElementById("Title").value;
        const director = document.getElementById("Director").value;
        const hero = document.getElementById("Hero").value;
        const heroine = document.getElementById("Heroine")

        fetch(`http://localhost:5285/api/Movies`, {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify({ title, director, hero, heroine })
        })
            .then(response => {
                if (!response.ok) {
                    throw new Error(`HTTP error! Status :${response.status}`);
                }
                return response.json();
            })
            .then(() => {
                //clear fields after successfull creation
                document.getElementById("Title").value = "";
                document.getElementById("Director").value = "";
                document.getElementById("Hero").value = "";
                document.getElementById("Heroine").value = "";
                //refresh the tasklist
                displayMovie();
            })
            .catch(error => {
                console.error("Fetch Error :", error);
            });
    });

    updatemovieform.addEventListener("submit", (e) => {
        e.preventDefault();
        const Id = document.getElementById("Id").value;
        const newTitle = document.getElementById("NewTitle").value;
        

        fetch(`http://localhost:5285/api/Movies/${Id}`, {
            method: "PUT",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify({ Id, newTitle })
        })
            .then(response => {
                if (!response.ok) {
                    throw new Error(`HTTP error! Status :${response.status}`);
                }
                return response.json();
            })
            .then(() => {
                document.getElementById("taskId").value = "";
                document.getElementById("newTitle").value = "";
                
                displayMovie();
            })
            .catch(error => {
                console.error("Fetch Error :", error);
            });
    });


    deletemovieform.addEventListener("submit", (e) => {
        e.preventDefault();
        const DeleteId = document.getElementById("DeleteId").value;

        fetch(`http://localhost:5285/api/Movies/${DeleteId}`, {
            method: "DELETE"
        })
            .then(response => {
                if (!response.ok) {
                    throw new Error(`HTTP error! Status :${response.status}`);
                }
                return response.json();
            })
            .then(() => {
                document.getElementById("DeleteId").value = "";
                displayTask();
            })
            .catch(error => {
                console.error("Fetch Error :", error);
            });
    });

    displayMovie();

});