import axios from "axios";

const API_BASE_URL = "https://ping-charging-stations.azurewebsites.net/api";

export interface ChargingStation {
  id: number;
  name: string;
  location_id: number;
  availability: boolean;
}

export const fetchStations = () => {
  return axios.get(`${API_BASE_URL}/ChargingStations`);
};
