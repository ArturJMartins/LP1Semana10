### Diagrama UML

```mermaid
classDiagram
    Program --> Controller : association
    Program --> UglyView : association
    Controller o-- Player : aggregation
    Controller *-- CompareByName : composition
    Controller --> IView : association
    UglyView --|> IView : inheritance
    Controller ..> IView : dependency
    CompareByName --|> IComparer~Player~ : inheritance
    Player --|> IComparable~Player~ : inheritance
    ```