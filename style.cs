/* General Styles */
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

body {
  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
  line-height: 1.6;
  color: #333;
  background-color: #f4f4f4;
}

/* Header & Navigation */
header {
  background-color: #2c3e50;
  color: #ecf0f1;
  padding: 1rem 0;
  position: sticky;
  top: 0;
  z-index: 1000;
  box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
}

nav {
  display: flex;
  justify-content: space-between;
  align-items: center;
  max-width: 1200px;
  margin: 0 auto;
  padding: 0 2rem;
}

nav .logo {
  font-size: 1.8rem;
  font-weight: bold;
}

nav ul {
  list-style: none;
  display: flex;
  gap: 2rem;
}

nav a {
  color: #ecf0f1;
  text-decoration: none;
  transition: color 0.3s ease;
}

nav a:hover {
  color: #3498db;
}

/* Hero Section */
.hero {
  background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
  color: white;
  padding: 6rem 2rem;
  text-align: center;
  min-height: 500px;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
}

.hero h1 {
  font-size: 3rem;
  margin-bottom: 1rem;
}

.hero p {
  font-size: 1.3rem;
  margin-bottom: 2rem;
  opacity: 0.9;
}

.hero .cta-button {
  background-color: #fff;
  color: #667eea;
  padding: 0.8rem 2rem;
  border: none;
  border-radius: 5px;
  font-size: 1rem;
  cursor: pointer;
  transition: transform 0.3s ease, box-shadow 0.3s ease;
}

.hero .cta-button:hover {
  transform: translateY(-2px);
  box-shadow: 0 5px 15px rgba(0, 0, 0, 0.2);
}

/* Container */
.container {
  max-width: 1200px;
  margin: 0 auto;
  padding: 0 2rem;
}

/* Sections */
section {
  padding: 4rem 0;
}

section h2 {
  font-size: 2.5rem;
  margin-bottom: 2rem;
  text-align: center;
  color: #2c3e50;
}

/* About Section */
#about {
  background-color: #fff;
}

.about-content {
  display: grid;
  grid-template-columns: 1fr 1fr;
  gap: 2rem;
  align-items: center;
}

.about-content img {
  max-width: 100%;
  border-radius: 10px;
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
}

.about-content p {
  font-size: 1.1rem;
  line-height: 1.8;
  color: #555;
}

/* Portfolio/Projects Section */
#portfolio {
  background-color: #ecf0f1;
}

.portfolio-grid {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
  gap: 2rem;
}

.portfolio-item {
  background: white;
  border-radius: 10px;
  overflow: hidden;
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
  transition: transform 0.3s ease, box-shadow 0.3s ease;
}

.portfolio-item:hover {
  transform: translateY(-10px);
  box-shadow: 0 8px 16px rgba(0, 0, 0, 0.2);
}

.portfolio-item img {
  width: 100%;
  height: 200px;
  object-fit: cover;
}

.portfolio-item-content {
  padding: 1.5rem;
}

.portfolio-item h3 {
  font-size: 1.3rem;
  margin-bottom: 0.5rem;
  color: #2c3e50;
}

.portfolio-item p {
  color: #666;
  margin-bottom: 1rem;
}

.portfolio-item a {
  color: #3498db;
  text-decoration: none;
  font-weight: bold;
  transition: color 0.3s ease;
}

.portfolio-item a:hover {
  color: #667eea;
}

/* Skills Section */
#skills {
  background-color: #fff;
}

.skills-grid {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
  gap: 2rem;
}

.skill-card {
  background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
  color: white;
  padding: 2rem;
  border-radius: 10px;
  text-align: center;
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
}

.skill-card h3 {
  margin-bottom: 1rem;
  font-size: 1.3rem;
}

.skill-card p {
  line-height: 1.8;
}

/* Contact Section */
#contact {
  background-color: #2c3e50;
  color: white;
  text-align: center;
}

#contact h2 {
  color: white;
}

.contact-form {
  max-width: 600px;
  margin: 0 auto;
}

.contact-form input,
.contact-form textarea {
  width: 100%;
  padding: 1rem;
  margin-bottom: 1rem;
  border: none;
  border-radius: 5px;
  font-family: inherit;
  font-size: 1rem;
}

.contact-form textarea {
  resize: vertical;
  min-height: 150px;
}

.contact-form button {
  background-color: #3498db;
  color: white;
  padding: 0.8rem 2rem;
  border: none;
  border-radius: 5px;
  font-size: 1rem;
  cursor: pointer;
  transition: background-color 0.3s ease;
}

.contact-form button:hover {
  background-color: #2980b9;
}

/* Footer */
footer {
  background-color: #1a252f;
  color: #ecf0f1;
  text-align: center;
  padding: 2rem;
}

footer p {
  margin-bottom: 0.5rem;
}

.social-links {
  margin-top: 1rem;
}

.social-links a {
  color: #ecf0f1;
  text-decoration: none;
  margin: 0 1rem;
  transition: color 0.3s ease;
}

.social-links a:hover {
  color: #3498db;
}

/* Responsive Design */
@media (max-width: 768px) {
  .about-content {
    grid-template-columns: 1fr;
  }

  .hero h1 {
    font-size: 2rem;
  }

  nav ul {
    gap: 1rem;
  }

  section h2 {
    font-size: 2rem;
  }
}