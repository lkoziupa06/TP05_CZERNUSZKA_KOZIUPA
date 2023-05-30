using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP05_CZERNUSZKA_KOZIUPA.Models;

public static class Escape{
    private static string[] incognitasSalas {get; set;} = new string [4];
    private static int estadoJuego {get;set;} = 1;
    private static void inicializarJuego(){
        incognitasSalas[0] = "";
        incognitasSalas[1] = "";
        incognitasSalas[2] = "";
        incognitasSalas[3] = "";
    }
    public static int GetEstadoJuego(){
        return estadoJuego;
    }
    public static bool ResolverSala(int sala, string incognita){
        bool esCorrecta = false;
        if(sala == estadoJuego){
            if(incognitasSalas[0] == null) inicializarJuego();
            if(incognitasSalas[sala--] == incognita){
                esCorrecta = true;
                estadoJuego++;
            }
        }
        return esCorrecta;
    }
}