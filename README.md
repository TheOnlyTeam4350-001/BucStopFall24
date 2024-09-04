# BucStop
### A Team [Redacted] Project
### Members:
> Josh Rucevice, Bryson Brandon, Kurt Brewer, Patrick Vergason
> Ethan Hensley, Charlie Shahan, Ethan Webb
#### CSCI 4350
#### Spring 2024, East Tennessee State University

### Overview:
This project is a game website made by and for ETSU students. It
is a place to put games created by ETSU students.
This project also communicates to a microservice with HTTP calls for the game information, the repository is hosted in the links below. BucStop also interacts with this Microservice through an API Gateway whose repository is also listed below. It is deployed with the microservice using docker compose, see the scripts folder for the docker-compose.yml file.

### Backlog Information:
* [Backlog Fall 2023](https://brandonbcb02.atlassian.net/jira/software/projects/SCRUM/boards/1/backlog?epics=visible&atlOrigin=eyJpIjoiMjgzYjkwZGI0ZjU3NDNiM2JhMDNiOWU4MDliZjQ0YjEiLCJwIjoiaiJ9)
* [Backlog Spring 2024](https://docs.google.com/document/d/100WxhA-8cx5tWQfZs9JMoHvPGJO37cdkfATp0Td0uos/edit?usp=sharing)
### Project Plan:
[Project Plan Doc link](https://docs.google.com/document/d/1lopwnWAl-WA3CEhNJGGfSxrIz2FvDrpibQSW70T8A-o/edit)

### Project Structure: 
To understand the project structure, familiarize yourself with the
MVC (Model View Controller) structure. When clicking on a game, 
a value will be passed to the controller, which will decide which 
game to load. This is divided between the MVC folders in the main
BucStop folder.

* Bucstop
	* Controllers
		* This folder has the controllers, which allow pages to 
			link together and pass information between them.
	* Models
		* This folder has the basis for the Game class.
	* Views
		* Games
			* This folder has the pages related to games, such as
				the index page and the default game page.
		* Home
			* This folder contains the main pages used by the site, 				
				such as the home page, admin page, and privacy page.
		* Shared 
			* This contains other important pages and/or resources 
				that aren't in the other two folders, including the
				default layout and the error page.
	* wwwroot
		* This folder contains the resources used by the project, 
			including images, the javascript games, the icons, etc.
### Associated Repositories
* [Microservice Repo](https://github.com/Redacted-Team/4350_002_Fall23_MicroService)
* [API Gateway](https://github.com/Redacted-Team/4350_002_Fall23_APIGateway)
* [Tetris Microservice](https://github.com/Redacted-Team/4350_002_Fall23_Tetris)
* [Snake Microservice](https://github.com/Redacted-Team/4350_002_Fall23_Snake)
* [Pong Microservice](https://github.com/Redacted-Team/4350_002_Fall23_Pong)

### Help
For more documentation on how to run locally and how to set up deployments, see the google docs below:
* [Team Redacted Video Playlist](https://youtube.com/playlist?list=PLxsGO-QGipWmVzxFkVbA-o6BUW5eRdk3H&si=a7jHaNBgdTtXgoJ4)
* [Running Locally](https://docs.google.com/document/d/1gfUpjZNfqWyv1ohUW1IaS8fOhXp0hOx6tFQVXBADa8Q/edit?usp=sharing)
* [How to Deploy](https://docs.google.com/document/d/1VElVP9HrOafxdM0HfD9jjM8HvnzBSpXhhq1O9VtTTug/edit?usp=sharing)
