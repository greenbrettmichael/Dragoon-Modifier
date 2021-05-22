﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dragoon_Modifier {
    public static class GameController {
        public static byte InventorySize;
        public static void Run(Emu emulator) {
            while (Constants.RUN) {
                try { 
                    switch (emulator.MemoryController.GetGameState()) {
                        case GameState.Battle:
                            break;
                        case GameState.Field:
                            FieldController.Field(emulator);
                            break;
                        case GameState.Overworld:
                            FieldController.Overworld(emulator);
                            break;
                    }
                    Thread.Sleep(250);
                } catch (Exception ex) {
                    Constants.RUN = false;
                    Constants.WriteGLog("Program stopped.");
                    Constants.WritePLogOutput("INTERNAL SCRIPT ERROR");
                    Constants.WriteOutput("Fatal Error. Closing all threads.");
                    Constants.WriteError(ex.ToString());
                }
            }
        }
    }
}
