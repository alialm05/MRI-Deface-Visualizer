# MRI Defacing Visualizer Tool 

This graphical tool allows you to visualize MRI images of faces before and after it being defaced on the PyDeface algorithm. It has a lot of features, and more to be added soon. You can switch between the defaced image and the original, change transparency of the head and rotate around the face to investigate the structures of the brain. 

 

## How to Reproduce? 

This is the basic chart showing the process of how this project can be completed 


The first thing you need are the raw NIfTi files, these are neuroimaging data files that image part of the brain. It is also worthy to note that you will need good quality NIfTi’s as you won’t be able to progress to the steps later on when it comes to extracting the inner structures of the brain, like the subcortical structures. For this project, I used the sample NIfTi file in the 3D Slicer package. 
 

When receiving the file, you can view it using the open-source 3D slicer software, and tinker with it, like with using the threshold (shift) tool in the volume-rendering module. 3D slicer is mostly used for just viewing the files though, and exporting them segments as obj files. With the FSL library that you can download on Linux/MAC or on WSL for Windows, you can extract the structures of the brain like the subcortical structures, and segment parts of the brain like white and grey matter. FSL has other tools you can use. I will provide the Documentation here 

After extracting the structures from the head, you can open them in 3D slicer to view them and also save them as obj file. But this is only the structures. For the head itself, since it's a NIfti file, you must use a conversion tool, for me I found a cool repository that can do this called nii2mesh, it's an open-source C tool that converts neuroimaging files from voxels into polygons, here is the repo for it. 

Now for the defaced image, the steps are the same, except before converting the image into and obj, deface it using PyDeface (with the dependencies it requires) and repeat the same steps that were done for the original image. 

 

Now you can add them to the game in Unity. First download Unity, then pull my GitHub repo for the game files, and open them in the Unity Hub like so: 

 

Once you open it, you can have access to the development of this project! 

 

In the “Model Stage” Object in the explorer, this stores the current Head model that will be shown when playing the game: 

 

In the inspector, you can see the properties declared in the “ToggleModel” script, the property “CurrentModel” can be set to any head model you want it to be. 

 

As you can see, there are two versions, the original model and the defaced model. Each one will be a game object group containing the head object and the structures. Other structures can be added into this game-object group. 

 

To change to a different model, it's recommended to use the same group name and just insert it inside it, replacing the old object model. That way there is minimized debugging and modifying of the scripts. 

Example: if you want to insert a new original head object “MRHead2” it would be inserted inside “HeadGroup” replacing “MRhead” 

 

 

 

 

 

 

### Switch Buttons: 

 

These buttons store the object it would switch to when pressed, when it is clicked, the changeModel method in the ToggleModel script will be fired, passing the object assigned to it in the inspector, for example in the defaced button: 

 

  

 

 

 

## Recommendations: 

This project is very early in Beta, and a lot can be added to it. All it consists of right now is some basic mechanics, so it's very bare bones. 

It is also recommended to read through the scripts made, to understand how the features work. 

 

 

## Source Code: 

Repo for the files: https://github.com/alialm05/MRI-Deface-Visualizer 

 

### Other Required Tools: 

3D Slicer: https://www.slicer.org/ 

FSL: https://fsl.fmrib.ox.ac.uk/fsl/docs/#/ 

Nii2Mesh: https://github.com/neurolabusc/nii2mesh 

PyDeface: https://github.com/poldracklab/pydeface 

Unity: https://unity.com/download 

 

 

 

 

 
