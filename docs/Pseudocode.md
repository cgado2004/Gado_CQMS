# Clinic Queue Management System — Pseudocode

## Problem Analysis (IPO)

| Category | Requirement |
|---|---|
| Inputs | Patient Name, Age, Reason for Visit, Patient Type |
| Processing | Determine the priority, validate input, and generate the next shared queue number |
| Outputs | Queue Number, Patient Type, Priority |

---

## ADD TO QUEUE

```
Begin

Declare queueCounter, queueNumber, priority, patientType

Input Patient Name, Age, Reason for Visit, Patient Type

If Patient Type is not selected Then
    Display "Please select a Patient Type."
    End
End If

If Age is empty or Age is not a number or Age <= 0 Then
    Display "Please enter a valid age."
    End
End If

queueCounter = queueCounter + 1

queueNumber = "Q" + Format(queueCounter with 3 digits)

If Patient Type = "Emergency" Then
    priority = "EMERGENCY"
Else If Patient Type = "Senior" Then
    priority = "SENIOR PRIORITY"
Else If Patient Type = "Pregnant" Then
    priority = "PRIORITY"
Else
    priority = "REGULAR"
End If

Output queueNumber, Patient Type, priority

End
```

---

## CLEAR

```
Begin

Clear txtName
Clear txtAge
Clear txtReason
Clear cboPatientType
Clear lblQueueNumber
Clear lblPatientType
Clear lblPriority

End
```

---

## Mermaid Flowchart (editable source)

```mermaid
flowchart TD
    Start([Start]) --> Input[/Input Patient Name, Age, Reason for Visit, Patient Type/]
    Input --> D1{Patient Type selected?}
    D1 -- No --> Err1[Display "Please select a Patient Type."]
    Err1 --> End1([End])
    D1 -- Yes --> D2{Age is valid? not empty, a number, > 0}
    D2 -- No --> Err2[Display "Please enter a valid age."]
    Err2 --> End2([End])
    D2 -- Yes --> P1[queueCounter = queueCounter + 1]
    P1 --> P2[queueNumber = "Q" + Format queueCounter with 3 digits]
    P2 --> D3{Patient Type = Emergency?}
    D3 -- Yes --> PriE[priority = EMERGENCY]
    D3 -- No --> D4{Patient Type = Senior?}
    D4 -- Yes --> PriS[priority = SENIOR PRIORITY]
    D4 -- No --> D5{Patient Type = Pregnant?}
    D5 -- Yes --> PriP[priority = PRIORITY]
    D5 -- No --> PriR[priority = REGULAR]
    PriE --> Out[Output queueNumber, Patient Type, Priority]
    PriS --> Out
    PriP --> Out
    PriR --> Out
    Out --> Finish([End])
```
