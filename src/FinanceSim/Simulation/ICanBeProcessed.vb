Public Interface ICanBeProcessed
  ReadOnly Property Due As SimulationDueInfo
  Sub Process(state As SimulationState, processDate As Date)
End Interface