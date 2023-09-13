import axios from "axios";

const API_BASE_URL = "https://ping-charging-stations.azurewebsites.net/api";

export interface ChargingStationLocation {
  id: number;
  street: string;
  zip: number;
  city: string;
  country: string;
}

export const fetchLocations = () => {
  return axios.get(`${API_BASE_URL}/Locations`);
};
