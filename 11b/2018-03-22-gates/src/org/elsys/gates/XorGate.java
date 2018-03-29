package org.elsys.gates;

public class XorGate  extends BinaryGate implements Gate{

	public XorGate(Wire in1, Wire in2, Wire out) {
		super(in1, in2, out);
		// TODO Auto-generated constructor stub
	}


	public XorGate(Wire in1, Wire in2, Wire out) {
		this(in1, in2, out, "XorGate");
	}
}
