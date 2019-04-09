package main

import "testing"

func TestWorkshop(t *testing.T) {
  v := Test()
  if v != true {
    t.Errorf("test was incorrect, got: %b, want: %b, v, true)
  }
}
