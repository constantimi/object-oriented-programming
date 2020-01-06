package org.elsys.gates;

import java.util.ArrayList;

public abstract class GateFactory {

	public static Gate makeXorGate(Wire in1, Wire in2, Wire out, String name) {
		CompositeGate xorGate = new CompositeGate(name);

		xorGate.addInput(in1);
		xorGate.addInput(in2);
		xorGate.addOutput(out);

		Wire a = new Wire("xorA");
		Wire b = new Wire("xorB");
		Wire c = new Wire("xorC");

		Gate orGate = new OrGate(in1, in2, a);
		Gate andGate1 = new AndGate(in1, in2, b);
		Gate notGate = new InverterGate(b, c);
		Gate andGate2 = new AndGate(a, c, out);

		xorGate.addGate(orGate);
		xorGate.addGate(andGate1);
		xorGate.addGate(notGate);
		xorGate.addGate(andGate2);

		return xorGate;
	}

	public static Gate makeXorGate(Wire in1, Wire in2, Wire out) {
		return makeXorGate(in1, in2, out, "XorGate");
	}

	public static Gate makeHalfAdder(Wire a, Wire b, Wire s, Wire c, String name) {
		CompositeGate halfAdder = new CompositeGate(name);
		
		halfAdder.addInput(a);
		halfAdder.addInput(b);
		halfAdder.addInput(c);
		halfAdder.addInput(s);
		
		XorGate xor = new XorGate(a, b, s);
		halfAdder.addGate(xor);
		AndGate and = new AndGate(a, b, c);
		halfAdder.addGate(and);
		return halfAdder;
	}

	public static Gate makeHalfAdder(Wire a, Wire b, Wire s, Wire c) {
		return makeHalfAdder(a, b, s, c, "HalfAdder");
	}

	public static Gate makeFullAdder(Wire a, Wire b, Wire cIn, Wire sum, Wire cOut, String name) {
		CompositeGate fullAdder = new CompositeGate(name);
		
		fullAdder.addInput(a);
		fullAdder.addInput(b);
		fullAdder.addInput(cIn);
		fullAdder.addInput(cOut);
		fullAdder.addInput(sum);
		
		Wire wire1 = new Wire("wire1");
		Wire wire2 = new Wire("wire2");
		Wire wire3 = new Wire("wire3");
		Wire wire4 = new Wire("wire4");
		
		XorGate xor1 = new XorGate(a, b, wire1);
		fullAdder.addGate(xor1);
		AndGate and1 = new AndGate(a, b, wire2);
		fullAdder.addGate(and1);
		XorGate xor2 = new XorGate(cIn, wire1, sum);
		fullAdder.addGate(xor2);
		AndGate and2 = new AndGate(cIn, wire1, wire3);
		fullAdder.addGate(and2);
		AndGate and3 = new AndGate(a, b, wire4);
		fullAdder.addGate(and3);
		OrGate or = new OrGate(wire3, wire4, cOut);
		fullAdder.addGate(or);
		return fullAdder;
	}

	public static Gate makeFullAdder(Wire a, Wire b, Wire cIn, Wire sum, Wire cOut) {
		return makeFullAdder(a, b, cIn, sum, cOut, "FullAdder");
	}
	
	public static Gate makeRippleCarryAdder(Wire a[], Wire b[], Wire cIn, Wire sum[], Wire cOut) {
		assert a.length == b.length;
		assert a.length == sum.length;
		int n = a.length;
		
		ArrayList<Wire> wire = new ArrayList<Wire>();
		
		wire.add(cIn);
		for (int i = 1; i < n; i++) {
			Wire w = new Wire("wire");
			wire.add(w);
		}
		wire.add(cOut);
		//adder.addGate( makeFullAdder(a[i], b[i], cIn , sum[i], cOut) );
		int i;
		CompositeGate adder = new CompositeGate("RippleCarryAdder");
		
		adder.addGate( makeFullAdder(a[0], b[0], wire.get(0), sum[0], wire.get(1)) );
		for ( i = 1; i < n; i++) {	
			adder.addGate( makeFullAdder(a[i], b[i], wire.get(i), sum[i], wire.get(i+1)) );
		}
		i--;
		adder.addGate( makeFullAdder(a[i], b[i], wire.get(i), sum[i], wire.get(n)) );
		
		return adder;
	}
}
