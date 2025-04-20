/* styles.css - Custom CSS for Course Cards */

/* Ensure uniform image size */
.course - img {
width: 100 %;  /* Make image fill card width */
height: 200px; /* Set fixed height for uniformity */
    object-fit: cover; /* Crop image to fit */
    border - top - left - radius: 10px;
    border - top - right - radius: 10px;
}

/* Style the course cards */
.card {
    border-radius: 10px;
box - shadow: 0px 4px 8px rgba(0, 0, 0, 0.1);
transition: transform 0.2s ease-in-out;
height: 100 %;
}

.card: hover {
transform: scale(1.03); /* Hover effect */
}

.card - body {
display: flex;
    flex - direction: column;
    justify - content: space - between;
}

/* Container spacing */
.container {
    padding-top: 20px;
}
