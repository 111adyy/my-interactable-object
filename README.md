# UE5 Interactive Objects Prototype

🎮 **Unreal Engine 5 – Dynamic Object Interactions**

This project is a prototype in **C++ and UE5** where the player can interact with any object in the world. Each object detects when the player is pointing at it and responds by applying **physical impulses** in the camera's forward direction, creating more immersive gameplay mechanics.

![Demo of interactive objects](Docs/demo.gif)

---

## **Key Features**
- **Modular Interface:** `IInteractInterface` allows any object to become interactable easily.
- **Object Detection:** Uses **LineTrace** from the player's camera.
- **Real-time Physics:** Objects respond realistically to impulses.
- **Scalable Code:** Adding new interactable objects only requires implementing the interface.
- **Ready for Testing:** Perfect for prototyping interaction mechanics.

---

## **How to Use**
1. Clone the repository.
2. Open the project in **Unreal Engine 5**.
3. Place `AInteractableActor` instances in your level.
4. Play and point at the objects to see them react to your interactions.

---

## **Future Improvements**
- Multiple object interactions at once.
- Pickup and inventory mechanics.
- Visual and sound effects when interacting with objects.
- Expandable to more complex gameplay interactions.

---

## **Demo**
Check out the demo video showing the player interacting with objects in real time, applying physics impulses dynamically.

---

## **Technologies**
- **Unreal Engine 5**
- **C++**
- **Gameplay Interfaces**
- **Physics Simulation**
