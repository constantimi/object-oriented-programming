package org.elsys.part1;

public class Ball {
	private Double volume;
	private String sport;
	
	public Ball(double volume, String sport) {
		this.volume = volume;
		this. sport = sport;
	}


	@Override
	public int hashCode() {
		final int prime = 31;
		int result = 1;
		result = prime * result + ((sport == null) ? 0 : sport.hashCode());
		result = prime * result + ((volume == null) ? 0 : volume.hashCode());
		return result;
	}


	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		Ball other = (Ball) obj;
		if (sport == null) {
			if (other.sport != null)
				return false;
		} else if (!sport.equals(other.sport))
			return false;
		if (volume == null) {
			if (other.volume != null)
				return false;
		} else if (!volume.equals(other.volume))
			return false;
		return true;
	}


	public void setValume(Double valume) {
		this.volume = valume;
	}

	public void setSport(String sport) {
		this.sport = sport;
	}

	public double getVolume() {
		return volume;
	}

	public String getSport() {
		return sport;
	}
}