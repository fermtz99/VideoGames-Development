﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Symbol {
    private string name;

    // properties
    public string Name {
        get {
            return name;
        }
    }

    public Symbol(string name) {
        this.name = name;
    }
}
