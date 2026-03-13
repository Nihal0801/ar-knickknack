# AR Taj Mahal Knick-Knack

Student: Nihal Patel  
Course: CS 5136 – Virtual / Augmented Reality  
University: University of Cincinnati  

---

## Project Overview

This project implements an Augmented Reality (AR) knick-knack using Unity and Vuforia Engine. The application uses a physical cube marker that can be detected by a webcam to display a 3D augmented scene representing a meaningful location.

The location chosen for this project is the Taj Mahal in Agra, India. The Taj Mahal is one of the Seven Wonders of the World and an iconic historical monument. When the cube marker is detected by the camera, a small AR scene appears on top of the cube displaying a model of the Taj Mahal along with environmental elements.

The application also includes information panels on the cube faces that provide real-time and contextual information about the location. These panels display the location name, current weather conditions, the local time in Agra, and additional descriptive information.

The goal of this project is to demonstrate how Augmented Reality objects can function as digital knick-knacks that represent places, memories, or experiences while integrating interactive data and visual elements.

---

## Application Features

### Marker-Based AR Tracking

The application uses the Vuforia Engine for marker-based AR tracking. A physical cube marker is used as the tracking target. When the webcam detects the cube marker, the AR scene appears anchored to the cube in real time.

The tracking system allows the AR scene to move naturally as the cube moves, creating the illusion that the digital environment is physically attached to the cube.

---

### 3D Environment

The AR scene contains a small 3D environment themed around the Taj Mahal. The environment includes the Taj Mahal model and surrounding elements designed to represent the location visually.

Scene elements include:

- Taj Mahal 3D model
- Trees and landscape elements
- Water canal area
- Ground and environment textures
- Scene lighting

These components combine to create a recognizable visual representation of the location.

---

### Cube Information Panels

Each side of the cube displays a panel with different information about the location.

#### Location Panel

One side of the cube displays the name of the location being represented. In this case, the panel shows the Taj Mahal along with its geographic location in Agra, India.

This panel acts as the identifying label for the AR knick-knack.

---

#### Weather Panel

Another cube face displays the current weather conditions in Agra, India. Weather data is retrieved using the OpenWeather API.

The weather panel displays:

- Current temperature
- Weather conditions
- Location name

Weather data updates periodically to reflect current conditions.

---

#### Local Time Panel

One cube face displays the current local time in Agra, India. The time is calculated using a UTC offset to convert system time into the correct time zone.

This allows the application to display the correct time regardless of where the application is being run.

---

#### Information Panel

An additional panel displays general information about the Taj Mahal, including its historical significance and recognition as a UNESCO World Heritage Site.

This panel provides contextual information about the location represented in the AR scene.

---

### Ambient Sound

Ambient background sound is included in the scene to improve immersion. The sound is subtle and intended to enhance the experience without distracting from the visual environment.

---

### Lighting

Lighting is used to highlight the Taj Mahal model and environment objects. The lighting setup improves visual clarity and helps make the scene more visually appealing.

---

## Technologies Used

The following technologies were used to build this project:

- Unity Game Engine
- Vuforia Engine (Augmented Reality SDK)
- C# scripting
- OpenWeather API
- TextMesh Pro for UI text rendering

---

## Project Structure

The repository contains the core Unity project files required to run the application.


### Assets

The Assets directory contains the main content of the project including:

- Scripts
- 3D models
- Materials and textures
- Audio files
- Scene files
- UI elements

### Packages

The Packages directory contains Unity package dependencies used by the project.

### ProjectSettings

The ProjectSettings directory contains Unity configuration files required to run the project.

Unity will automatically regenerate temporary directories such as Library and Temp when the project is opened.

---

## Models and Assets

### External Models

Some models used in the scene were imported from external sources including environmental models such as trees and landscape assets.

These models were used for educational purposes within the project.

### Custom Elements

Several scene components were designed or configured within the project including:

- Information panels
- Scene layout
- AR object placement
- Environment configuration

---

## Running the Project

To run this project locally:

1. Clone the repository

git clone https://github.com/Nihal0801/ar-knickknack.git


2. Open Unity Hub.

3. Click "Add Project".

4. Select the cloned repository folder.

5. Open the main scene in Unity.

6. Press Play in Unity.

7. Show the cube marker to the webcam to activate the AR scene.

Once the cube marker is detected, the AR environment will appear attached to the cube.

---

## Development Process

The project was developed using Unity with Vuforia for marker tracking. The development process included setting up the AR camera, configuring the cube marker, importing models, creating the environment, and developing scripts for displaying dynamic data such as weather and time.

C# scripts were used to retrieve weather data from the OpenWeather API and calculate the correct time for the location.

The project was tested using a webcam to ensure stable marker detection and smooth AR tracking.

---

## Challenges

Several technical challenges were encountered during development including:

- Configuring Vuforia marker tracking correctly
- Ensuring the AR scene remained stable without excessive jitter
- Integrating the OpenWeather API into the Unity environment
- Managing large Unity files when uploading the project to GitHub
- Ensuring that text panels remained readable on cube faces

These challenges helped improve understanding of AR application development and Unity project management.

---

## Future Work

Possible improvements for the project include:

- Adding a second AR knick-knack location
- Creating scene changes based on weather conditions
- Implementing time-of-day lighting changes
- Adding animations to scene objects
- Implementing user interaction such as cube rotation actions

These features would further expand the interactivity of the AR environment.

---

## Use of AI and Collaboration

AI tools were used during development to assist with debugging scripts, understanding API integration, and improving documentation clarity.

Discussions with classmates also helped identify solutions to technical issues related to Unity configuration and AR tracking.

---

## Author

Nihal Patel  
Computer Science Student  
University of Cincinnati

GitHub Repository  
https://github.com/Nihal0801/ar-knickknack

---

## Course Information

CS 5136 – Virtual / Augmented Reality  
University of Cincinnati  

Project Assignment: AR Knick-Knack