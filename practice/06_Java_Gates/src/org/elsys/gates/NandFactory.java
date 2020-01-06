package org.elsys.gates;

public abstract class NandFactory {

	public static Gate makeNotGate(Wire in, Wire out, String name) {
		NandGate not = new NandGate(in, in, out, name);
		return not;
	}

	public static Gate makeNotGate(Wire in, Wire out) {
		return makeNotGate(in, out, "NandNot");
	}

	public static Gate makeAndGate(Wire in1, Wire in2, Wire out, String name) {
		//AndGate and = new AndGate(in1, in2, out, name);
		CompositeGate comp = new CompositeGate(name);
		comp.addInput(in1);
		comp.addInput(in2);
		comp.addInput(out);
		Wire wire1 = new Wire("wire1");
		NandGate nand1 = new NandGate(in1, in2, wire1);
		comp.addGate(nand1);
		NandGate nand2 = new NandGate(wire1, wire1, out);
		comp.addGate(nand2);
		return comp;
	}

	public static Gate makeAndGate(Wire in1, Wire in2, Wire out) {
		return makeAndGate(in1, in2, out, "NandAnd");
	}

	public static Gate makeOrGate(Wire in1, Wire in2, Wire out, String name) {
		//OrGate or = new OrGate(in1, in2, out, name);
		CompositeGate comp = new CompositeGate(name);
		comp.addInput(in1);
		comp.addInput(in2);
		comp.addInput(out);
		Wire wire1 = new Wire("wire1");
		Wire wire2 = new Wire("wire2");
		NandGate nand1 = new NandGate(in1, in1, wire1);
		comp.addGate(nand1);
		NandGate nand2 = new NandGate(in2, in2, wire2);
		comp.addGate(nand2);
		NandGate nand3 = new NandGate(wire1, wire2, out);
		comp.addGate(nand3);
		return comp;
	}

	public static Gate makeOrGate(Wire in1, Wire in2, Wire out) {
		return makeOrGate(in1, in2, out, "NandOr");
	}

	public static Gate makeXorGate(Wire in1, Wire in2, Wire out, String name) {
		//XorGate xor = new XorGate(in1, in2, out, name);
		CompositeGate comp = new CompositeGate(name);
		comp.addInput(in1);
		comp.addInput(in2);
		comp.addInput(out);
		Wire wire1 = new Wire("wire1");
		Wire wire2 = new Wire("wire2");
		Wire wire3 = new Wire("wire3");
		NandGate nand1 = new NandGate(in1, in2, wire1);
		comp.addGate(nand1);
		NandGate nand2 = new NandGate(in2, wire1, wire2);
		comp.addGate(nand2);
		NandGate nand3 = new NandGate(in1, wire1, wire3);
		comp.addGate(nand3);
		NandGate nand4 = new NandGate(wire2, wire3, out);
		comp.addGate(nand4);
		return comp;
	}

	public static Gate makeXorGate(Wire in1, Wire in2, Wire out) {
		return makeXorGate(in1, in2, out, "NandXor");
	}

}
